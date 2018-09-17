using System;
using System.Collections.Generic;
using System.Linq;

namespace LibManga
{
    public class Recherche
    {
        public Recherche()
        {
        }

        //méthode de recherche de manga
        public void Rechercher(List<Manga> ListeManga, string NomM, string GenreM, string EditeurM)
        {
            var results = ListeManga.Where(Manga => Manga.Nom.Contains(NomM) && Manga.Genre.Contains(GenreM) && Manga.Editeur.Contains(EditeurM));
            foreach (var manga in results)
            {
                Console.WriteLine(manga);
            }
        }

        //méthode de recherche de BD surchargée
        public void Rechercher(List<BD> ListeBD, string NomB, string GenreB, string EditeurB)
        {
            var results = ListeBD.Where(BD => BD.Nom.Contains(NomB) && BD.Genre.Contains(GenreB) && BD.Editeur.Contains(EditeurB));
            foreach (var BD in results)
            {
                Console.WriteLine(BD);
            }
        }

        //méthode d'affichage de la liste des mangas
        public void Listing(List<Manga> listeManga)
        {
            foreach (var manga in listeManga)
            {
                Console.WriteLine(manga);
            }
        }
        //méthode d'affichage de la liste des BD
        public void Listing(List<BD> listeBD)
        {
            foreach (var BD in listeBD)
            {
                Console.WriteLine(BD);
            }
        }
    }
}