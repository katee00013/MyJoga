using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJoga
{
    public static class PodaciPrijave
    {

            public static int KorisnikID { get; set; }
            public static string KorisnickoIme { get; set; }
            public static int UlogaKorisnika { get; set; }

            public static void OtvoriSesiju(_19001_DBDataSet.KorisnikRow korisnik)
            {
                KorisnikID = korisnik.ID_korisnik;
                KorisnickoIme = korisnik.Korisnicko_ime;
                UlogaKorisnika = korisnik.Tip_korisnika;
            }

            public static void ZatvoriSesiju()
            {
                KorisnikID = -1;
                KorisnickoIme = "";
                UlogaKorisnika = -1;
            }

        
    }
}
