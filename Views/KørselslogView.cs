using NuGet.Protocol.Plugins;
using System;
using System.Windows.Forms;
using Tur_Retur_Kørselslog.PladsholderTekst;

namespace Tur_Retur_Kørselslog
{
    public partial class KørselslogView : Form
    {        
        SQLRepository _repo = null;        
        PladsholderLogik _pgl = null;

        public KørselslogView()
        {
            InitializeComponent();

            _repo = new SQLRepository();
            _pgl = new PladsholderLogik();

            //C# - anonymous functions and event handlers
            SetEventForAllTextBox();

        }

        private void SetEventForAllTextBox()
        {
            //C# - anonymous functions and event handlers
            this.Opret_Stamdata_Navn_textbox.Leave += (sender, e) =>
            {
                var result = _pgl.TilføjPladsholder(Opret_Stamdata_Navn_textbox.Text);
                Opret_Stamdata_Navn_textbox.Text = result;
            }; //new EventHandler()

            //C# - anonymous functions and event handlers
            this.Opret_Stamdata_Navn_textbox.Enter += (sender, e) => { Opret_Stamdata_Navn_textbox.Text = _pgl.FjernPladsholder(Opret_Stamdata_Navn_textbox.Text); }; //new EventHandler()

            
        }

        private void Opret_Stamdata_Navn_PlaceholderText(object sender, System.EventArgs e)
        {
            var result = _pgl.FjernPladsholder(Opret_Stamdata_Navn_textbox.Text);
            Opret_Stamdata_Navn_textbox.Text = result;


           

        }

        
        
    }
}


//private void Opret_Stamdata_Opret_Click(object sender, System.EventArgs e)
//{
//    BrugerOpret nyBruger = new BrugerOpret
//    {
//        Navn = Opret_Stamdata_Navn_textbox.Text,
//        OpretDato = Opret_Stamdato_Dato_dateTimePicker.Value,
//        Nrplade = Opret_Stamdata_Nummerplade.Text
//    };

//    int newId = _repo.OpretBruger(nyBruger);

//    nyBruger.Id = newId;
//}


