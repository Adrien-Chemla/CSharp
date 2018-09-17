using System;


namespace LibManga
{
    public class Manga : MediaPapier
    {
        //constructeur de la classe manga
        public Manga()
        {
            //attribution des valeurs de la classe manga héritée de mediaPapier
            Nom = "Nom du manga";
            Genre = "Genre : Seinen, Shojo, ...";
            Editeur = "Nom d'editeur";
        }

    }
}
