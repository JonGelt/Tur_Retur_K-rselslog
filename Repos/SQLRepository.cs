using System.Collections.Generic;
using System.Windows.Forms;
using Tur_Retur_Kørselslog.Klasse_Objekter;


namespace Tur_Retur_Kørselslog.Repos
{
    internal class SQLRepository
    {

        internal void SQLOpretBruger(Bruger bruger)
        {
         
            bruger.Id = GetNewId();
            bruger.Navn = txtBoxNavn;
            bruger.Dato = dateTimePickerNu.Value;
            bruger.Nrplade = txtBoxNrPlade;

            opretBruger.BrugerList.Add(bruger);




        }

        int GetNewId()
        {
            //for (int i = 0; i <= bruger.Id; i++)
            //{
            //   return i;
            //}
            return 1;
        }

        private void TestDataMathias(string txtBoxNavn, DateTimePicker dateTimePickerNu, string txtBoxNrPlade)
        {
            foreach (var item in collection)
            {
                List<Bruger> brugere = new List<Bruger>
                {
                    new Bruger() { Id = GetNewId(), Navn = txtBoxNavn, Dato = dateTimePickerNu.Value, Nrplade = txtBoxNrPlade },
                    new Bruger() { Id = GetNewId(), Navn = txtBoxNavn, Dato = dateTimePickerNu.Value, Nrplade = txtBoxNrPlade }
                };
            }
        }


    }
}

