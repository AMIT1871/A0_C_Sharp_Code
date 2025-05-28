////--------------------------- return --------------------------------------------------
//// return the method value where method is calling
//// Method & function are same thing use for code reusability
//// 1 Metod over loading --> Method name same but argument different
//// 2 Method over wriding -->Method overriding allows a derived class (child class)
//// to modify the behavior of its base class (parent class).  //class ke ander method hota hai


////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace A0_C_Sharp_Code
////{
////    internal class A18_method               //A18_method is class
////    {
////        static void Main(String[] args)
////        {
////            int r = add(10, 20);            // Method calling
////            Console.WriteLine(r);
////            Great();                        // Method calling
////        }

////        static int add(int x, int y)        // Method defining/static-for connecting class A18_method
////        {                                   // int return value datatype
////            return x + y;
////        }

////        static void Great()                 // voide if you donr want to return
////        {
////            Console.WriteLine("Welcome to code world");
////        }


////    }
////}



////-------------------------- 1 Method Over Loading ---------------------------------------------
////using System;
////namespace A0_C_Sharp_Code
////{
////    internal class A18_method
////    {


////        static float Average(int a, int b, int c)
////        {
////            float sume = a + b + c;
////            return sume / 3;
////        }



////        static float Average(int a, int b)
////        {
////            float sume = a + b;
////            return sume / 2;
////        }


////        public static void Main(string[] args)
////        {

////            Console.WriteLine(Convert.ToDecimal(Average(2, 3, 4)));
////            Console.WriteLine(Convert.ToDecimal(Average(2, 3)));


////        }
////    }
////}



////-------------------------- 2 Method OverRiding ---------------------------------------------
//using System;
//namespace A0_C_Sharp_Code
//{
//    internal class A18_method
//    {
//        public class BaseClass                    //Parant Class
//        {
//            public virtual void Display()
//            {
//                Console.WriteLine("Base class Display method");
//            }
//        }

//        public class DerivedClass : BaseClass      //Chaild class
//        {
//            public override void Display()
//            {
//                Console.WriteLine("Derived class Display method");
//            }
//        }

//        public class Program
//        {
//            public static void Main(string[] args)
//            {
//                BaseClass baseObj = new BaseClass();
//                DerivedClass derivedObj = new DerivedClass();

//                baseObj.Display();  // Output: Base class Display method
//                derivedObj.Display(); // Output: Derived class Display method

//                BaseClass obj = new DerivedClass();
//                obj.Display(); // Output: Derived class Display method (due to runtime polymorphism)





//            }
//        }
//    }
//}