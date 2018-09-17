using System;
using LibManga;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace Mangasharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var manga = new Manga();
            var BD = new BD();

            var barreDeRecherche = new Recherche();

            //création de la liste de manga
            List<Manga> listeManga = new List<Manga>();

            //création de liste de BD
            List<BD> listeBD = new List<BD>();

            //affichage du menu
            Console.WriteLine("--------- Bienvenue ! ----------");
            Console.WriteLine("1. Rechercher un manga par nom, genre, editeur");
            Console.WriteLine("2. Rechercher unE BD par nom, genre, editeur");
            Console.WriteLine("3. Afficher la liste des mangas");
            Console.WriteLine("4. Afficher la liste des BD");
            string reponse = Console.ReadLine();
            int c =Int32.Parse(reponse);

            //sélection de la valeur du menu
            switch(c){

                case 1:
                    //récupération des informations sur le média
                    Console.WriteLine("Entrez le nom du manga : ");
                    string NomM = Console.ReadLine();

                    Console.WriteLine("Entrez le genre du manga : ");
                    string GenreM = Console.ReadLine();

                    Console.WriteLine("Entrez l'éditeur du manga : ");
                    string EditeurM = Console.ReadLine();

                    //utilisation des valeurs récupérées plus haut 
                    barreDeRecherche.Rechercher(listeManga, NomM, GenreM, EditeurM);
                    break;
                case 2:
                    //récupération des informations sur le média
                    Console.WriteLine("Entrez le nom de la BD : ");
                    string NomB = Console.ReadLine();

                    Console.WriteLine("Entrez le genre de la BD : ");
                    string GenreB = Console.ReadLine();

                    Console.WriteLine("Entrez l'éditeur de la BD : ");
                    string EditeurB = Console.ReadLine();

                    //utilisation des valeurs récupérées plus haut
                    barreDeRecherche.Rechercher(listeBD, NomB, GenreB, EditeurB);
                    break;
                case 3:
                    //affichage de la table Manga
                    barreDeRecherche.Listing(listeManga);
                    break;
                case 4:
                    //affichage de la table BD
                    barreDeRecherche.Listing(listeBD);
                    break;
                default:
                    Console.WriteLine("Veuillez entrer une valeur correcte ! ");
                    break;
            }

            ////connection à la base de donnée
            //var connectionStringBuilder = new SqliteConnectionStringBuilder
            //{
            //    //récupération de l'emplacement de la BDD
            //    DataSource = "BDD/MediaBDD.db"
            //};

            //using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            //{

            //    connection.Open();

            //    var selectCommand = connection.CreateCommand();

            //    //requete SQL pour la base de données
            //    selectCommand.CommandText = "SELECT NomM, GenreM, EditeurM, NomB, GenreB, EditeurB FROM Manga, BD";

            //    using (var reader = selectCommand.ExecuteReader())
            //    {           
            //        while (reader.Read())
            //        {
            //            //si c = 3 affichage de la table Manga
            //            if(c == 3){
            //                var message = $"{reader["NomM"]} | {reader["GenreM"]} | {reader["EditeurM"]} ";
            //                System.Console.WriteLine(message);
            //            }
            //            //si c = 4 affichage de la table BD
            //            else if (c == 4){
            //                var message = $"{reader["NomB"]} | {reader["GenreB"]} | {reader["EditeurB"]} ";
            //                System.Console.WriteLine(message);
            //            }

            //        }
            //    }
            //    //Arret de la connection à la BDD
            //    connection.Close();
            //}
        }

    }
}