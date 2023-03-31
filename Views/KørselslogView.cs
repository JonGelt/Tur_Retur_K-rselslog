using System;
using System.IO;
using System.Windows.Forms;
using Tur_Retur_Kørselslog.Repos;

namespace Tur_Retur_Kørselslog
{
    public partial class KørselslogView : Form
    {
        SQLRepository _repo = null;
        PlaceholderLogic _pgl = null;
        public static string FileFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "C:/Users/JD/Desktop/Kørselslog Test Data";
        public static string FileName = FileFolder + "/AppData.txt";
      

        public KørselslogView()
        {


            InitializeComponent();
             

            _repo = new SQLRepository();
            _pgl = new PlaceholderLogic();

            
        }

        private void KørselslogView_Load(object sender, System.EventArgs e)
        {
            _pgl.StringAssigner(Opret_Stamdata_Navn_textbox, Opret_Stamdata_Nummerplade, Rediger_Stamdata_Nummerplade, Opret_Kørselslog_Nummerplade, Opret_Kørselslog_Opgave);
        }

        private void Opret_Stamdata_Opret_Click(object sender, System.EventArgs e)
        {


            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "C:/Users/JD/Desktop/Kørselslog Test Data/AppData.txt"))
            {
                File.WriteAllText(FileName, _repo.SQLOpretBruger(Opret_Stamdata_Navn_textbox, Opret_Stamdato_Dato_dateTimePicker, Opret_Stamdata_Nummerplade);
                //_repo.SQLOpretBruger(Opret_Stamdata_Navn_textbox.Text, Opret_Stamdato_Dato_dateTimePicker, Opret_Stamdata_Nummerplade.Text);
            }
           
            

        }

        private void Personale_Gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Opret_Stamdata_Navn_textbox.Text = Personale_Gridview.SelectedRows[0].Cells[0].Value.ToString();

        }
    }
}





