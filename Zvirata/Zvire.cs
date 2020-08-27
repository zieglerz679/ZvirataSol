using System;

namespace Zvirata
{
    public abstract class Zvire
    {
        private string jmeno;

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        private DateTime datumNarozeni;

        public DateTime DatumNarozeni
        {
            get { return datumNarozeni; }
            set { datumNarozeni = value; }
        }

        public abstract string OblibeneJidlo();

        public virtual string Zvuk()
        {
            return "<ticho>";
        }
    }
}
