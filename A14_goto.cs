////--------------------------- goto ----------------------------------------
//// If you want print 1 to 10 natural no without using loop you can use goto
//// goto :- Repeat task without using loop
//// Jump anywher you want


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A0_C_Sharp_Code
//{
//    internal class A14_goto
//    {
//        public static void Main(String[] args)
//        {
//            int i = 1;
//        go:                 //cod jump here 
//            if (i <= 10)
//            {
//                Console.WriteLine(i++);
//                //i++;
//                goto go;     // go ki jagah koi bhi name use kr sakte ho
//            }

//        }
//    }
//}


//------------------------------- Example -------------------------------------
// Scip perticuler segment with the help of goto


//using System;
//using System.Net;
//namespace A0_C_Sharp_Code
//{
//    class A14_goto
//    {
//        public static void Main(String[] args)
//        {
//            int i = 1;
//            if (i == 1)
//            {
//                Console.WriteLine("Amit's code");
//                goto down;
//            }
//            Console.WriteLine("Amit 1");  //jimp this line / not print / ignore this line
//        down:                         // code jump here
//            Console.WriteLine("Amit 2");
//        }
//    }
//}