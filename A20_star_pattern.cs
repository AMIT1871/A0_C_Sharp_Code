////////-------------------------- star pattern ------------------------------------------------------




////////----------------------------------- 1 pattern --------------------------------------------------
//////// *
//////// * *
//////// * * *
//////// * * * *
//////// * * * * *

//////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Text;
//////using System.Threading.Tasks;

//////namespace A0_C_Sharp_Code                      
//////{
//////    internal class A20_star_pattern
//////    {
//////        public static void Main(String[] args)
//////        {
//////            for(int i=1; i<=5; i++)             // for row
//////            {
//////                for(int j=1; j<=i; j++)         // for column
//////                {
//////                    Console.Write("* ");         //for print in same line use only(Console.Wrote) not use Line
//////                }
//////                Console.WriteLine();            //for next line
//////            }
//////        }
//////    }
//////}




////////----------------------------------- 2 pattern --------------------------------------------------
////// * * * * *
////// * * *
////// * * *
////// * *
////// *

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A0_C_Sharp_Code
//{
//    internal class A20_star_pattern
//    {
//        public static void Main(String[] args)
//        {
//            for (int i = 1; i <= 5; i++)             // for row
//            {
//                for (int j = 5; j >= i; j--)         // for column
//                {
//                    Console.Write("* ");         //for print in same line use only(Console.Wrote) not use Line
//                }
//                Console.WriteLine();            //for next line
//            }
//        }
//    }
//}



////////----------------------------------- 3 pattern --------------------------------------------------
////// * * * * *
////// * * * * *
////// * * * * *
////// * * * * *
////// * * * * *

////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace A0_C_Sharp_Code
////{
////    internal class A20_star_pattern
////    {
////        public static void Main(String[] args)
////        {
////            for (int i = 1; i <= 5; i++)             // for row
////            {
////                for (int j = 1; j <= 5; j++)         // for column
////                {
////                    Console.Write("* ");         //for print in same line use only(Console.Wrote) not use Line
////                }
////                Console.WriteLine();            //for next line
////            }
////        }
////    }
////}


////////----------------------------------- 4 pattern --------------------------------------------------
//////         *
//////       * *
//////     * * *
//////   * * * *
////// * * * * *

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Remoting.Services;
//using System.Text;
//using System.Threading.Tasks;

//namespace A0_C_Sharp_Code
//{
//    internal class A20_star_pattern
//    {
//        public static void Main(String[] args)
//        {
//            int n;                                      // n define rows
//            Console.WriteLine("Enter the value of n");
//            n = Convert.ToInt32(Console.ReadLine());

//            for (int i = 1; i <= n; i++)             // for row
//            {
//                for (int j = 1; j <= (n - j); j++)         // for column
//                {
//                    Console.Write(" ");         //for print in same line use only(Console.Wrote) not use Line
//                }

//                for (int k = 1; k < (i * 2) - 1; k++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();

//            }
//        }
//    }
//}



