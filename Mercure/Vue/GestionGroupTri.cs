using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure.Vue
{
    /// <summary>
    ///    Cette classe est destiné à gerer le groupe d’éléments  qui devra refléter le trie actuel de la colonne. 
    /// </summary>
    /// <remarks>
    ///     La formation des groupes est faite en fonction d'une colonne 
    /// </remarks>
    class GestionGroupTri
    {
        private ListViewGroupTri GroupTri;

        private Hashtable[] GroupTables;

        private int GroupColumn = 0;

        private bool isRunningXPOrLater = OSFeature.Feature.IsPresent(OSFeature.Themes);

        private ListView Listview_;

        /// <summary>
        ///  Constructeur de l'objet GestionGroupTri
        /// </summary>
        /// <param name="list"> la liste view sur la quelle le tri se passera </param>
        public GestionGroupTri(ListView list)
        {
            Listview_ = list;
            this.Listview_.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClick);
            Init();
           
        }

        /// <summary>
        ///  Cette méthode permet de créer toutes les groupes possibles de toutes colonnes 
        /// </summary>
        private void Init()
        { 
            if (isRunningXPOrLater)
            {
                GroupTables = new Hashtable[Listview_.Columns.Count];
                for (int column = 0; column < Listview_.Columns.Count; column++)
                {
                    GroupTables[column] = CreerGroupsTable(column);
                }
            }
           
        }

        /// <summary>
        ///     Cette méthode permet de trier en fonction de l'ordre , et de former les groupes adequats de la colonne
        /// </summary>
        /// <param name="column">le numéro de la colonne </param>
        private void SetGroups(int column)
        {
            Listview_.Groups.Clear();
            Hashtable groups = (Hashtable)GroupTables[column];
            ListViewGroup[] groupsArray = new ListViewGroup[groups.Count];
            groups.Values.CopyTo(groupsArray, 0);

            GroupTri = new ListViewGroupTri(Listview_.Sorting);
            Array.Sort(groupsArray, GroupTri);
            Listview_.Groups.AddRange(groupsArray);

            foreach (ListViewItem item in Listview_.Items)
            {
                string subItemText = item.SubItems[column].Text;

                if (column == 0)
                {
                    subItemText = subItemText.Substring(0, 1);
                }
                item.Group = (ListViewGroup)groups[subItemText];

            }
        }

        /// <summary>
        ///  Cette methode cree un <see cref="Hashtable"/> les groupes avec une entrée pour chaque valeur en fonction de la colonne 
        /// </summary>
        /// <param name="column">numéro de la colonne </param>
        /// <returns></returns>
        private Hashtable CreerGroupsTable(int column)
        {
            Hashtable groups = new Hashtable();
            foreach (ListViewItem item in Listview_.Items)
            {
                string subItemText = item.SubItems[column].Text;
                if (column == 0)
                {
                    subItemText = subItemText.Substring(0, 1);
                }
                if (!groups.Contains(subItemText))
                {
                    groups.Add(subItemText, new ListViewGroup(subItemText,
                        HorizontalAlignment.Left));
                }
            }
            return groups;
        }

        /// <summary>
        ///   Cette methode permet de gérer l'évènement clic sur une colonne de la liste view
        ///   , pour trier la colonne en fonction de l'odre de <see cref="SortOrder"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Init();
            // Déterminer si la colonne sélectionnée est déjà la colonne triée.
            if ( e.Column == GroupColumn)
            {
                // Inverser le sens de tri en cours pour cette colonne.
                if (Listview_.Sorting == SortOrder.Ascending)
                {
                    Listview_.Sorting = SortOrder.Descending;

                }
                else
                {
                    Listview_.Sorting = SortOrder.Ascending;
                }


            }
            else
            {
                // Définir le numéro de colonne à trier ; par défaut sur croissant
                GroupColumn = e.Column;
                Listview_.Sorting = SortOrder.Ascending;

            }
            // Procéder au tri avec les nouvelles options.
            Listview_.Sort();
            SetGroups(GroupColumn);


        }


    }
}
