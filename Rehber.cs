using System;
using System.Collections;
using System.Collections.Generic;
 class Rehber
    {
        private static List<Person> rehber_listesi;

        public static List<Person> Rehber_listesi { get => rehber_listesi; set => rehber_listesi = value; }
        static Rehber()
        {
            rehber_listesi = new List<Person>(){
                new Person("Mehmet", "Karahanlı","0545 555 55 55"),
                new Person("Ziya", "Yılmaz","0544 444 44 44"),
                new Person("Polat", "Alemdar","0546 666 66 66"),
                new Person ("Süleyman", "Çakır","0543 333 33 33"),
                new Person("Memati", "Baş","0541 111 11 11")
            };
        }
    }