using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juke_Box
{
    class CD:Media
    {
        string artiste;
        int nombreDePistes;
        //Constructeur
        public CD(string titre, string artiste, int nombreDePistes, int duree):base (titre,duree)
        {
            this.artiste = artiste;
            this.nombreDePistes = nombreDePistes;
        }
        public override string Afficher()
        {
            return("CD: " +base.Afficher());
            
        }

    }
}
