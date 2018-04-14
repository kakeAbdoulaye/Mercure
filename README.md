Mercure
Ce projet a pour titre Mercure , il a été codé en c# avec l'interface graphique Windows Form dont le but est de lier une application à une base de donnée SQLite pour un mini magasin contenant des articles , des sous familles , des familles et des marques.
 - fonctionnalité : 
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
    Marque = ref , nomMarque 
    Sous Famille = ref , nomSousFamille , refFamille
    Famille = ref , nomFamille 
    Article = ref , description , refMarque , refSousFamille , prix , quantite
