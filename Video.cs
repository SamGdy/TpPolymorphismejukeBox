using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juke_Box
{
    class Video : Media
    {
        private string metteurEnScene;

        public Video(string titre, string metteurEnScene, int duree)
            : base(titre, duree)
        {
            this.metteurEnScene = metteurEnScene;
        }
        public override string Afficher()
        {
            return ("Video: " + base.Afficher());
            
        }
    }
}
