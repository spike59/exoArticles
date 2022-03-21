using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoArticles
{
    internal class Article
    {
        private int reference;
        public string designation;
        private float prixHT;
        private static float tauxTVA = 19.6f;
        public float PrixTTC
        {
            get { return prixHT + prixHT * tauxTVA / 100; }
        }
        public Article()
        {
            reference = 0;
            designation = "";
            prixHT = 0.0f;
        }
        public Article(int refe, string des, float prix, float taxe)
        {
            reference = refe;
            designation = des;
            prixHT = prix;
        }
        public Article(Article a)
        {
            reference = a.reference;
            designation = a.designation;
            prixHT = a.prixHT; 
        }
        public override string ToString()
        {
            string toString = "Référence: " + reference + " désignation: " + designation + " prix HT: " + prixHT.ToString();
            toString += " Prix TTC: " + PrixTTC.ToString() + "( " + tauxTVA.ToString() + ")";
            return toString;
        }

    }
}
