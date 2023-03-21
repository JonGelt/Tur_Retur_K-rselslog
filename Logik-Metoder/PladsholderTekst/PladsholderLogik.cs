using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tur_Retur_Kørselslog.PladsholderTekst
{
    public class PladsholderLogik
    {       
        TextBox _klp;
        string _klpt;

        public string TilføjPladsholder(string text)
        {
            
            if (text == "")
            {
                text = "Fornavn-Efternavn";
            }
                          
            return text;
        }
        public string FjernPladsholder(string text)
        {
            if (text == "Fornavn-Efternavn")
            {
                text = "";
            }

            return text;
        }

        public string Handler(object sender, EventArgs e)
        {
            return TilføjPladsholder(_klpt);  
           
        }

    }

}

