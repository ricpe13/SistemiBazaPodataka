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
                // ZelenaPovrsina.Entiteti.ZelenaPovrsina zp = s.Load<ZelenaPovrsina.Entiteti.ZelenaPovrsina>(r.ZelenaPovrsina.Id);
                // o.AngazovanZaZP = zp;

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

        #region Park

        public static void dodajPark(ParkBasic park)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.Park p = new Park();

                p.NazivP = park.NazivP;
                p.TipZ = park.TipZ;
                p.ZonaUgrozenosti = park.ZonaUgrozenosti;
                p.PovrsinaP = park.PovrsinaP;
                p.NazivGradskeOpstine = park.NazivGradskeOpstine;

                s.Save(p); s.Flush(); s.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.FormatExceptionMessage());
            }
        }

        #endregion


        #region Travnjak

        public static void dodajTravnjak(TravnjakBasic travnjak)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZelenaPovrsina.Entiteti.Travnjak t = new Travnjak();

                t.AdresaZgrade = travnjak.AdresaZgrade;
                t.PovrsinaT = travnjak.PovrsinaT;


                s.Save(t); s.Flush(); s.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.FormatExceptionMessage());
            }


            #endregion
        }
    }

}
