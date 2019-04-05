using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juke_Box
{
    class Media
    {
        string titre;
        int duree;
        bool enStock;
        string commentaire;
        public Media(string titre, int duree)
        {
            this.titre = titre;
            this.duree = duree;
            this.enStock = false;
            this.commentaire = "pas de com";
        }
        //Entrer un com
        public void SetCommentaire(string commentaire)
        {
            this.commentaire = commentaire;
        }
        //retourne le com
        public string GetCommentaire()
        {
            return this.commentaire;
        }
        //definit l'indicateur
        public void SetEnStock(bool enStock)
        {
            this.enStock = enStock;
        }
        //Retourne l'info si copie de ce cd
        public bool GetEnStock()
        {

            return this.enStock;
        }
        public virtual string Afficher()
        {
            return string.Format(" Titre: {0} d'une durée ({1} min)", this.titre, this.duree);
        }
    }
}
