using System;
using System.Collections;
using System.Collections.Generic;

namespace Telefon_Rehber
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag==true)
            {
                Console.WriteLine("İşlemler");
                Console.WriteLine("****************************************");
                Console.WriteLine("(1) Yeni Numara Kaydet");
                Console.WriteLine("(2) Var Olan Numarayi Sil");
                Console.WriteLine("(3) Varolan Numarayı Güncelle");
                Console.WriteLine("(4) Rehberi Listele");
                Console.WriteLine("(5) Rehberde Arama Yap\n");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                int selection = Convert.ToInt32(Console.ReadLine());


                switch (selection)
                {
                    case 1:
                        transactions.telefon_kaydet();
                        break;
                    case 2:
                        transactions.telefon_sil();
                        break;
                    case 3:
                        transactions.telefon_guncelle();
                        break;
                    case 4:
                        transactions.rehberi_listele();
                        break;
                    case 5:
                        transactions.rehberde_ara();
                        break;
                    default:
                        Console.WriteLine("Çıkış Yapılıyor........");
                        flag = false;
                        break;
                }
            }
        }
    }
    
}