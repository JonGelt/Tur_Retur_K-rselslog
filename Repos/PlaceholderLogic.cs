using System.Collections.Generic;
using System.Windows.Forms;


namespace Tur_Retur_Kørselslog.Repos
{
    public class PlaceholderLogic
    {

        private string TilføjPladsholder(string text, string textBase)
        {

            if (text == "")
            {
                text = textBase;
            }

            return text;

        }
        private string FjernPladsholder(string text, string textBase)
        {
            if (text == textBase)
            {
                text = "";
            }

            return text;

        }

        public void SetEventForAllTextBox(TextBox textBox, string textBase)
        {
            //C# - anonymous functions and event handle         

            textBox.Leave += (sender, e) =>
            {
                var result = TilføjPladsholder(textBox.Text, textBase);
                textBox.Text = result;
            };

            textBox.Enter += (sender, e) => { textBox.Text = FjernPladsholder(textBox.Text, textBase); };

        }


        public void StringAssigner(TextBox Opret_Stamdata_Navn_textbox, TextBox Opret_Stamdata_Nummerplade, TextBox Rediger_Stamdata_Nummerplade, TextBox Opret_Kørselslog_Nummerplade, TextBox Opret_Kørselslog_Opgave)
        {
            List<TextBox> textBoxList = new List<TextBox>();

            textBoxList.Add(Opret_Stamdata_Navn_textbox);
            textBoxList.Add(Opret_Stamdata_Nummerplade);
            textBoxList.Add(Rediger_Stamdata_Nummerplade);
            textBoxList.Add(Opret_Kørselslog_Nummerplade);
            textBoxList.Add(Opret_Kørselslog_Opgave);

            Opret_Stamdata_Navn_textbox.Text = " Fornavn-Efternavn";
            Opret_Stamdata_Nummerplade.Text = "    Nummerplade";
            Rediger_Stamdata_Nummerplade.Text = "     Nummerplade";
            Opret_Kørselslog_Nummerplade.Text = "     Nummerplade";
            Opret_Kørselslog_Opgave.Text = "       Destination";

            foreach (TextBox tb in textBoxList)
            {
                SetEventForAllTextBox(tb, tb.Text);
            }

        }


    }

}
