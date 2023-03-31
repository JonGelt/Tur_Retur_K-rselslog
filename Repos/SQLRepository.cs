using System.Collections.Generic;
using System.Windows.Forms;


namespace Tur_Retur_Kørselslog.Repos
{
    internal class SQLRepository
    {

        internal Bruger SQLOpretBruger(TextBox txtBoxNavn , DateTimePicker dateTimePickerNu, TextBox txtBoxNrPlade)
        {
            List<Bruger> brugere = new List<Bruger>
            {  new Bruger () { Id = GetNewId(), Navn = txtBoxNavn.Text, Dato = dateTimePickerNu.Value, Nrplade = txtBoxNrPlade.Text }, };

            return brugere;
                  
        }

        int GetNewId()
        {
            //for (int i = 0; i <= bruger.Id; i++)
            //{
            //   return i;
            //}
            return 1;
        }

       // private void TestDataMathias(string txtBoxNavn, DateTimePicker dateTimePickerNu, string txtBoxNrPlade)
        //{
            //foreach (var item in collection)
            //{
               // List<Bruger> brugere = new List<Bruger>
               // {
                 //   new Bruger() { Id = GetNewId(), Navn = txtBoxNavn, Dato = dateTimePickerNu.Value, Nrplade = txtBoxNrPlade },
                 //   new Bruger() { Id = GetNewId(), Navn = txtBoxNavn, Dato = dateTimePickerNu.Value, Nrplade = txtBoxNrPlade }
                //};
           // }
       // }


    }
}

