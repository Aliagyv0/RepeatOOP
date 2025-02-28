//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeTask
//{
//    //-Task 14.BankHesabı adında Class yaradın. Bu classın hesab, hesab adı hesab nömrəsi adında fieldləri olsun. Mədaxil və məxaric metodları vasitəsilə müştəri məlumatlarını ekrana çıxarın. (Encapsulation istifadə ediləcək.)
//    public class BankHesabı
//    {
//        private double hesab;
//        private string hesabAdi;
//        private string hesabNomresi;

//        public BankHesabı(string ad, string nomre, double ilkBalans)
//        {
//            hesabAdi = ad;
//            hesabNomresi = nomre;
//            Hesab = ilkBalans;
//        }
//        public double Hesab
//        {
//            get { return hesab; }
//            private set { hesab = value; }
//        }

//        public string HesabAdi
//        {
//            get { return hesabAdi; }
//            private set { hesabAdi = value; }
//        }

//        public string HesabNomresi
//        {
//            get { return hesabNomresi; }
//            private set { hesabNomresi = value; }
//        }


//        public void Medaxil(double medaxil)
//        {
//            if (medaxil > 0)
//            {
//                Hesab += medaxil;
//            }
//            else
//            {
//                throw new Exception("Medaxil sifirdan boyuk olmalidir");

//            }
//        }
//        public void Mexaric(double mexaric)
//        {
//            if (Hesab > 0)
//            {
//                Hesab -= mexaric;
//            }
//            else
//            {
//                throw new Exception("Balansda kifayet qeder vesait yoxdur!");
//            }
            
//        }

//       public void HesabMelumatlari()
//        {
//            Console.WriteLine($"Ad: {HesabAdi}");
//            Console.WriteLine($"HesabNomresi: {HesabNomresi}");
//            Console.WriteLine($"Hesab: {Hesab}");
//        }


//    }
   
//}
