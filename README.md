Mercure
Ce projet a pour titre Mercure , il a été codé en c# avec l'interface graphique Windows Form dont le but est de lier une application à une base de donnée SQLite pour un mini magasin contenant des articles , des sous familles , des familles et des marques.
 - fonctionnalité : 
   
    * Lecture d'un fichier XML  permettant de remplir la base de données.Avec deux modes de remplissage : 
        - intégration : Suppression  de tous les élements de la base de données , et l'inserer les nouveaux éléments lus
        - mise à jour : mise à jour des éléments dans la base de données s'il existe sinon l'inserer
    * Marque : 
      - ajouter , modifier et supprimer 
      - Liaison avec le clavier et la sourie 
      - Tri de la liste d'affichage par groupe  en fonction des colonnes 
    
    * Sous famille :
      - ajouter , modifier et supprimer 
      - Liaison avec le clavier et la sourie 
      - Tri de la liste d'affichage par groupe  en fonction des colonnes 
    
    * Famille : 
      - ajouter , modifier et supprimer 
      - Liaison avec le clavier et la sourie 
      - Tri de la liste d'affichage par groupe  en fonction des colonnes 
    
    * Article : 
      - ajouter , modifier et supprimer 
      - Liaison avec le clavier et la sourie 
      - Tri de la liste d'affichage par groupe  en fonction des colonnes 
    
    
  - Structure de la base de données :
    * Marque = ref , nomMarque 
    * Sous Famille = ref , nomSousFamille , refFamille
    * Famille = ref , nomFamille 
    * Article = ref , description , refMarque , refSousFamille , prix , quantite
    
    
    
 - Editeur : 
       - Visual Studio 2015
       - EntityFramework Version=6.0.0.0 , Version du Runtime = v4.0.30319
       
 - Auteur : 
       - Kake Abdoulaye 
       - Etudiant , ingénieur à Polytech Tours 
