using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCBH6_RESTFul
{
    class Jatekok
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        private string mufaj;

        public string Mufaj
        {
            get { return mufaj; }
            set { mufaj = value; }
        }

        private string kiado;

        public string Kiado
        {
            get { return kiado; }
            set { kiado = value; }
        }

        private string jatekmod;

        public string Jatekmod
        {
            get { return jatekmod; }
            set { jatekmod = value; }
        }

        public Jatekok()
        {

        }

        public Jatekok(int id, string nev, string mufaj, string kiado, string jatekmod)
        {
            this.Id = id;
            this.Nev = nev;
            this.Mufaj = mufaj;
            this.Kiado = kiado;
            this.Jatekmod = jatekmod;
        }

    }
}
