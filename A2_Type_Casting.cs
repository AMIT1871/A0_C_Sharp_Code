//// ------------------------------- Type Casting -------------------------------------
//// ek data type se dusre datatype me convert krna 
//// c# is a type safe langeage
//// variable datatype and value data type should be same 
////
////--------------- Type casting
//// There is 2 type of typecasting
//// 1 Implicit casting
////  ---- char to int to long to float to double
//// 2 Explicit casting
//// ----- manual convert 
////
//// 3 In c# there is builtin feature for convert datatype




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A0_C_Sharp_Code
//{
//    internal class A2_Type_Casting
//    {
//        static void Main(string[] args)
//        {

//            //----------------- 1 Implicit casting ---------------------------

//            int x = 3;           //Implicit casting -->char to int to long to float to double
//            float y = x;
//            double z = y;
//            //long w = z;          // Backword roule not valid only forword valid

//            Console.WriteLine(x);
//            Console.WriteLine(y);
//            Console.WriteLine(z);


//            //----------------- 2 Explicit casting ---------------------------

//            //int a = 3.4;       // is not valid couse 3.4 is a double type stype safe error
//            int a = (int)3.4;    // Double converted double to integer type
//            double p = (double)4.5F; // Float to double 

//            Console.WriteLine(a);
//            Console.WriteLine(p);


//            //---------------------- C# biltin feature -----------------------------

//            float q = 3.5F;
//            int s = Convert.ToInt32(q);

//            //Convert.ToString
//            //Convert.ToBoolean
//            //Convert.ToChar
//            //etc - there is multiple opetiones 

//            Console.WriteLine("s = " + s);//prit 4 due to round off


//            //---------------------- Concatination -----------------------------
//            Console.WriteLine("Enter how mutch candies do you want");
//            string candies = Console.ReadLine();
//            Console.WriteLine("You will get 4 more candies " + (Convert.ToInt32(candies) + 4));

//        }
//    }
//}
