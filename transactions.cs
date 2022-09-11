using System;
using System.Collections;
using System.Collections.Generic; 
using System.Linq;
class transactions
    {
 public static void telefon_kaydet()
        {
            Console.WriteLine("Lütfen ad giriniz".PadRight(35) + ":");
            string ad = Console.ReadLine().ToString();
            Console.WriteLine("Lütfen soyad giriniz".PadRight(35) + ":");
            string soyad = Console.ReadLine().ToString();
            Console.WriteLine("Lütfen telefon numarası giriniz".PadRight(35) + ":");
            string telefon = Console.ReadLine().ToString();

            Person register = new Person(ad, soyad, telefon);


            /* ilk bulunan değeri silmemek için ad ve soyad unique olarak alınmak isterse bu blok yorumdan çıkartılmalı
            if (Rehber.Rehber_listesi.Any(p => p.ad == kayit.ad) && Rehber.Rehber_listesi.Any(p => p.Soyad == kayit.Soyad))
            {
                Console.WriteLine($"{ad + " " + soyad} zaten kayitli!");
                return;
            }
            */

            if (Rehber.Rehber_listesi.Any(p => p.TelefonNumarasi == register.TelefonNumarasi))
            {
                Console.WriteLine("Bu numara zaten kayitli!");
                Console.WriteLine("****************************************");
                return;
            }

            Rehber.Rehber_listesi.Add(register);
            Console.WriteLine($"{ad + " " + soyad} adlı kisi {telefon} numarası ile eklendi.");
            Console.WriteLine("****************************************");
        }

        public static void telefon_sil()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string aranacakDeger = Console.ReadLine().ToString();
                if (Rehber.Rehber_listesi.Any(p => p.Ad.ToLower() == aranacakDeger.ToLower() || p.Soyad.ToLower() == aranacakDeger.ToLower()))
                {
                    Console.WriteLine($"{aranacakDeger} adli/soyadli kişi rehberden silinmek üzere, onaylıyor musunuz? (Y/N)");
                    string secim = Console.ReadLine().ToLower();
                    if (secim == "y")
                    {
                        Rehber.Rehber_listesi.Remove(Rehber.Rehber_listesi.Find(p => p.Ad.ToLower() == aranacakDeger.ToLower() || p.Soyad.ToLower() == aranacakDeger.ToLower()));
                        Console.WriteLine($"{aranacakDeger} ad/soyadli kayıt başarıyla silindi!");
                        Console.WriteLine("****************************************");
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi sonlandırıldı.");
                        Console.WriteLine("****************************************");
                        flag = false;
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
                    Console.WriteLine("* Yeniden denemek için: (2)");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Silme işlemi sonlandırıldı.");
                            Console.WriteLine("****************************************");
                            flag = false;
                            break;
                        case 2:
                            Console.WriteLine("****************************************");
                            break;

                    };
                }
            }
        }

        public static void telefon_guncelle()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                string aranacakDeger = Console.ReadLine().ToString();
                if (Rehber.Rehber_listesi.Exists(p => p.Ad.ToLower() == aranacakDeger.ToLower() || p.Soyad.ToLower() == aranacakDeger.ToLower()))
                {
                    Console.WriteLine("Lütfen yeni numarayı giriniz: ");
                    string numara = Console.ReadLine().ToString();
                    Rehber.Rehber_listesi.Find(p => p.Ad == aranacakDeger || p.Soyad == aranacakDeger).TelefonNumarasi = numara;
                    Console.WriteLine($"{aranacakDeger} adli/soyadli kullanıcının başarıyla güncellendi.");
                    Console.WriteLine("****************************************");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için: (1)");
                    Console.WriteLine("* Yeniden denemek için: (2)");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Güncelleme işlemi sonlandırıldı.");
                            Console.WriteLine("****************************************");
                            flag = false;
                            break;
                        case 2:
                            Console.WriteLine("****************************************");
                            break;
                    };
                }
            }
        }

        public static void rehberi_listele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("****************************************");
            foreach (Person register in Rehber.Rehber_listesi)
            {
                Console.WriteLine($"İsim: {register.Ad}");
                Console.WriteLine($"Soyad: {register.Soyad}");
                Console.WriteLine($"Telefon Numarası: {register.TelefonNumarasi}");
                Console.WriteLine("---------------------------------------------");
            }
            Console.WriteLine("****************************************");
            Console.ReadLine();
        }

        public static void rehberde_ara()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("****************************************");
            Console.WriteLine("İsim veya soyade göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasina göre arama yapmak için: (2)");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                    string aranacakDeger = Console.ReadLine().ToString();
                    if (Rehber.Rehber_listesi.Exists(p => p.Ad.ToLower() == aranacakDeger.ToLower() || p.Soyad.ToLower() == aranacakDeger.ToLower()))
                    {
                        foreach (Person register in Rehber.Rehber_listesi.FindAll(p => p.Ad == aranacakDeger || p.Soyad == aranacakDeger))
                        {
                            Console.WriteLine($"İsim: {register.Ad}");
                            Console.WriteLine($"Soyad: {register.Soyad}");
                            Console.WriteLine($"Telefon Numarası: {register.TelefonNumarasi}");
                            Console.WriteLine("---------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        Console.WriteLine("****************************************");
                    }
                    break;
                case 2:
                    Console.WriteLine("Lütfen aramak istediğiniz telefon numarasını giriniz:");
                    aranacakDeger = Console.ReadLine().ToString();
                    if (Rehber.Rehber_listesi.Exists(p => p.TelefonNumarasi == aranacakDeger))
                    {
                        foreach (Person register in Rehber.Rehber_listesi.FindAll(p => p.TelefonNumarasi == aranacakDeger))
                        {
                            Console.WriteLine($"İsim: {register.Ad}");
                            Console.WriteLine($"Soyad: {register.Soyad}");
                            Console.WriteLine($"Telefon Numarası: {register.TelefonNumarasi}");
                            Console.WriteLine("---------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        Console.WriteLine("****************************************");
                    }
                    break;
                default:
                    break;
            }
        }
    }

