using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Thesaurus
{
    // definition af de forskellige elementer
    internal class ThessaurusDatabase
    {
        public string TermName { get; set; }
        public string TermDisc { get; set; }
        public string TermCat { get; set; }

        /* public string Term(string Name, string Disc, string Category)
         {
             string FinalTerm = Name;
             string FinalDiscription = Disc;
             string FinalCategory = Category;
         }
        */

        // Opsætning af begrebet
        public ThessaurusDatabase(string ternName, string termDisc, string termCat)
        {
            TermName = ternName;
            TermDisc = termDisc;
            TermCat = termCat;
        }
        /*
                public string TermLookup(TermName, Termdisc, TermCat)
                {

                }
        */
    }
}