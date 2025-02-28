//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeTask
//{
//    internal class Car
//    {
//        //- Task 3. "Car" sinfi yaradın və avtomobil xüsusiyyətlərini qeyd edin.Bu sinifdə marka, model, istehsal ili kimi xüsusiyyətlər olmalıdır.Encapsulation istifadə edərək avtomobilin xüsusiyyətlərini ekrana çıxarın.
//        private string _marka;
//        private string _model;
//        private int _productionYear;

    
//        public string Marka
//        {
//            get { return _marka; }
//             set { _marka = value; }
//        }
//        public string Model
//        {
//            get { return _model; }
//             set { _model = value; }
//        }
//        public int ProductionYear
//        {
//            get { return _productionYear; }
//             set {
//                if (value < 2000)
//                {
//                    throw new Exception("Istehsal ili 2000-den boyuk olmalidir");
//                }
//                _productionYear = value;
//            }
//        }

//        public void AutomobileDetail()
//        {
//            Console.WriteLine($"Marka: {Marka}");
//            Console.WriteLine($"Model: {Model}");
//            Console.WriteLine($"Istehsal ili: {ProductionYear}");
//        }
//    }
//}
