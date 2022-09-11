using System;
public class Person
    {
        private string ad ;
        private string soyad;
        private string telefonNumarasi;

        public Person(string _ad, string _soyad, string _telefonNumarasi)
        {
            this.ad=_ad;
            this.soyad=_soyad;
            this.telefonNumarasi=_telefonNumarasi;
        }
        public Person(){}

        public string Ad { get =>ad; set=>ad=value; }
        public string Soyad { get=>soyad; set=>soyad=value;}
        public string TelefonNumarasi { get=>telefonNumarasi; set=>telefonNumarasi=value; } 
        


    }