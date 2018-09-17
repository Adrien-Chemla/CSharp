using System;

namespace LibManga
{
    //définition de la classe mère mediaPapier en abstraite
    public abstract class MediaPapier
    {
        public MediaPapier(){
            Notation = new Notation();
        }
        //création des variables et des accesseurs
        private String nom;
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private String genre;
        public String Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        private String editeur;
        public String Editeur
        {
            get { return editeur; }
            set { editeur = value; }
        }
        private Notation notation;
        public Notation Notation
        {
            get { return notation; }
            set { notation = value;}
        }
    }
}
