//////------------------------------- array -----------------------------------------------
////// store multiple smae type of value
////// Reverse array



//////------------------------------ 1D ARRAY -----------------------------------------
//////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Text;
//////using System.Threading.Tasks;

//////namespace A0_C_Sharp_Code
//////{
//////    internal class     internal class A17_array
//////    {
//////        public static void Main(String[] args)
//////        {
//////            int[] a = { 10, 20, 30, 40 };   // only store same type of value
//////            foreach(int i in a)
//////            {
//////                Console.WriteLine(i);
//////            }
//////        }
//////    }
//////}




//////------------------------------  2D ARRAY -----------------------------------------
////// input 2D array and print

////using System;
////namespace A0_C_Sharp_Code
////{
////    class A17_array
////    {
////        public static void Main(String[] args)
////        {
////            int[,] a = new int[2, 2];             // 2*2 array range
////            Console.WriteLine("Enter the elements of 2D array");
////            for(int i=0; i<2; i++)
////            {
////                for(int j=0; j<2; j++)
////                {
////                    a[i, j] = Convert.ToInt32(Console.ReadLine());
////                }
////            }

////            for (int i = 0; i < 2; i++)
////            {
////                for (int j = 0; j < 2; j++)
////                {
////                    Console.Write(a[i,j]+" "); //for print in same line use only(Console.Wrote) not use Line
////                }
////                Console.WriteLine();
////            }
////        }
////    }
////}


////----------------------------- Reverse Array ----------------------------------------------
//using System;
//namespace A0_C_Sharp_Code
//{
//    class A17_array
//    {
//        public static void Main(String[] args)
//        {
//            int n;
//           Console.WriteLine("Enter the array size");
//            n = Convert.ToInt32(Console.ReadLine());


//            int[] a = new int[n];                         // input size of array
//           Console.WriteLine("Enter the array elements");





//            for (int i = 0; i < a.Length; i++)                // for input array
//            {
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }



//            //-------------print array-----------
//            Console.WriteLine("\n\nPrint array");
//            for (int i=0; i<a.Length; i++)
//            {
//                Console.WriteLine(a[i]);
//            }



//            //-------------Print revers array -------------
//            Console.WriteLine("\n\nPrint revers array");
//            for (int j = (a.Length)-1; j >= 0; j--)
//            {
//                Console.WriteLine(a[j]);
//            }



//        }
//    }
//}