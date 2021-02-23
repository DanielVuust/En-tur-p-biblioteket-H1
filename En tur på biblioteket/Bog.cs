using System;
using System.Collections.Generic;
using System.Text;

namespace En_tur_på_biblioteket
{
    class Bog
    {
        private string _Titel;
        private string _Forfatter;
        private int _Sidetal;

        public string Titel{
            get{ return _Titel; } 
            set{ _Titel = value; }
        }
        public string Forfatter { 
            get { return _Forfatter; } 
            set { _Forfatter = value; } 
        }
        public int Sidetal { 
            get { return _Sidetal; } 
            set { _Sidetal = value; } 
        }
        public Bog(string Titel)
        {
            this._Titel = Titel;
        }
    }
}
