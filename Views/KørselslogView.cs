using System.Windows.Forms;
using Tur_Retur_Kørselslog.Repos;

namespace Tur_Retur_Kørselslog
{
    public partial class KørselslogView : Form
    {
        SQLRepository _repo = null;
        PlaceholderLogic _pgl = null;

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
            Bruger bruger = new Bruger();

            bruger.Id = GetNewId();
            bruger.Navn = Opret_Stamdata_Navn_textbox.Text;
            bruger.Dato = Opret_Stamdato_Dato_dateTimePicker.Value;
            bruger.Nrplade = Opret_Stamdata_Nummerplade.Text;


            _repo.SQLOpretBruger(bruger);

        }
    }
}





