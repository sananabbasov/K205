using System;

namespace Initial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type safety



            // decimal ve float 

            // data type 

            // float, bool, double

            // value data types
            
            //string soyad = "Muradov"; //
            //int yas = 999999999;
            //decimal boy =  1.5M;
            //bool telebe = false;
            //long yas2 = 99999999999999;


            decimal qiymet = 5.555M;

            float qiymet2 = 5.3555F;


            // reference data types

            // class, interfacess // object, array

            /*string ad = "1";*/ // RAM  stack = 5

            // array - massiv 
            string[] telebeler = { "Aytac", "Gunel", "Vahid"}; // RAM // stack = telebeler | heap = 101 = { "Aytac", "Gunel", "Vahid"}

            string[] telebeler2 = { }; // RAM stack telebeler2 // heap = 102

            telebeler2 = telebeler; // RAM heap reference 101


            // Garbage Collector
            // Sniped
            // cw TABB 2x




            //Console.WriteLine("Adinizi daxil edin:"); // 1
            //string ad = Console.ReadLine(); // 2

            //// + birlesdirme operatorudur.

            //Console.WriteLine("Xos gelmissiniz " + ad); // 3



            // if/else swich case

            //string ad = "Aytac";

            //string fenn = "Proqramlasdirma";

            //int bal = 51;

            //int kecidBali = 51;

            //// < > == != >= <= 


            //if (bal >= kecidBali) // false bal = 50 > kecid bali 51
            //{
            //    Console.WriteLine("Tebrikler kecdinizi.");
            //}
            //else
            //{
            //    Console.WriteLine("Kesildin :D");
            //}



            Console.WriteLine("Xos gelmissiniz.");
            Console.WriteLine("Adinizi daxil edin : ");

            string ad = Console.ReadLine();

            Console.WriteLine("Balinizi daxil edin : ");

            string bal = Console.ReadLine();

            int yekunBal = Convert.ToInt32(bal); // string 56 convert int 56
            int kecidBali = 51;
            // yekun bal  = bal

            int kesirBali = kecidBali - yekunBal;

            if (yekunBal >= kecidBali)
            {
                Console.WriteLine(ad + " imtahannan kecdin.");
            }
            else
            {
                Console.WriteLine(ad + " cemi " + kesirBali +  " bal ile kesildin.");
            }

        }
    }
}
 