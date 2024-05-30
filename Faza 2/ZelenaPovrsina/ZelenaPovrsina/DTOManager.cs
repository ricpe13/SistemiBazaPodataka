using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenaPovrsina.DTO
{
    internal class DTOManager
    {
        #region Radnik
        public static void dodajRadnika(RadnikBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.Radnik o = new ZelenaPovrsina.Entiteti.Radnik();
          
                o.Ime = r.Ime;
                o.Prezime = r.Prezime;
                o.Jmbg = r.Jmbg;
                o.Adresa = r.Adresa;
                o.BrRadneKnjizice = r.BrRadneKnjizice;
                o.ImeRoditelja = r.ImeRoditelja;
                o.StrucnaSprema = r.StrucnaSprema;
                o.DatumRodj = r.DatumRodj;
                o.ZaZelenilo = r.ZaZelenilo;
                o.ZaZelenilo = r.ZaZelenilo;
                o.ZaHigijenu = r.ZaHigijenu;
                o.ZaObjekat = r.ZaObjekat;
                ZelenaPovrsina.Entiteti.ZelenaPovrsina zp = s.Load<ZelenaPovrsina.Entiteti.ZelenaPovrsina>(r.ZelenaPovrsina.Id);
                o.AngazovanZaZP = zp;

                s.SaveOrUpdate(o);



                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.FormatExceptionMessage());
            }
        }
        #endregion
    }
}
