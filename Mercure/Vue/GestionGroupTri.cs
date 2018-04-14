using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure.Vue
{
    class GestionGroupTri
    {
        private ListViewGroupTri groupTri;

        private Hashtable[] groupTables;

        int groupColumn = 0;

        private bool isRunningXPOrLater = OSFeature.Feature.IsPresent(OSFeature.Themes);

        private ListView listview;

        public GestionGroupTri(ListView list)
        {
            listview = list;
            this.listview.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClick);
          //  list.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClick);
            init();
           
        }
        private void init()
        { 
            // init 
            if (isRunningXPOrLater)
            {
                groupTables = new Hashtable[listview.Columns.Count];
                for (int column = 0; column < listview.Columns.Count; column++)
                {
                    groupTables[column] = CreerGroupsTable(column);
                }
            }
           
        }
        private void SetGroups(int column)
        {
            listview.Groups.Clear();
            Hashtable groups = (Hashtable)groupTables[column];
            ListViewGroup[] groupsArray = new ListViewGroup[groups.Count];
            groups.Values.CopyTo(groupsArray, 0);

            groupTri = new ListViewGroupTri(listview.Sorting);
            Array.Sort(groupsArray, groupTri);
            listview.Groups.AddRange(groupsArray);

            foreach (ListViewItem item in listview.Items)
            {
                string subItemText = item.SubItems[column].Text;

                if (column == 0)
                {
                    subItemText = subItemText.Substring(0, 1);
                }
                item.Group = (ListViewGroup)groups[subItemText];

            }
        }

        private Hashtable CreerGroupsTable(int column)
        {
            Hashtable groups = new Hashtable();
            foreach (ListViewItem item in listview.Items)
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

        private void ColumnClick(object sender, ColumnClickEventArgs e)
        {
            init();
            // Déterminer si la colonne sélectionnée est déjà la colonne triée.
            if ( e.Column == groupColumn)
            {
                // Inverser le sens de tri en cours pour cette colonne.
                if (listview.Sorting == SortOrder.Ascending)
                {
                    listview.Sorting = SortOrder.Descending;

                }
                else
                {
                    listview.Sorting = SortOrder.Ascending;
                }


            }
            else
            {
                // Définir le numéro de colonne à trier ; par défaut sur croissant
                groupColumn = e.Column;
                listview.Sorting = SortOrder.Ascending;

            }
            // Procéder au tri avec les nouvelles options.
            listview.Sort();
            SetGroups(groupColumn);


        }


    }
}
