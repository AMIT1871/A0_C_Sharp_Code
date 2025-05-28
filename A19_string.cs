////----------------------- string ------------------------------------
////•	Print string
////•	Find string length
////•	Concat two string
////•	Convert string upper to lower & vice – versa
////•	Reverse string
////•	Compare two string.
////•	Reverse string.
//// Escape charecters and (print " and \ ) 



////---------------------- print string-------------------------------------
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A0_C_Sharp_Code
//{
//    internal class A19_string
//    {
//        public static void Main(String[] args)
//        {
//            string str = "Amit", str2 = "Amita", str3 = "Amit";


//            Console.WriteLine(str);                  // print whole string
//            Console.WriteLine(str[3]);               // print 3rd index t
//            Console.WriteLine(str.Length);           // Print str length
//            Console.WriteLine(str.Equals(str2));     // if both equal output true otherwise false
//            Console.WriteLine(str.Equals(str3));     // if both equal output true othewrise false
//            Console.WriteLine(str + " " + str2);     // Concat two srings
//            Console.WriteLine(str.ToUpper());        // Convert to upper
//            Console.WriteLine(str.ToLower());        // Convert to lower
//            Console.WriteLine(str.Replace(str, str2));  // replace str to str2




//            string c = "You are grate ";
//            Console.WriteLine(c[0]); // access specific character
//            Console.WriteLine(c.IndexOf("You"));    //start in which index
//            Console.WriteLine(c.IndexOf("grate"));  //start in which index
//            Console.WriteLine(c.Substring(1));  //start from index 1
//            Console.WriteLine(c.Substring(5));  //start from index 5




//            //------------ Escape charecters ------------------------
//            Console.WriteLine("Ahmedabad is is \"gift\" city"); // print " 
//            Console.WriteLine("Ahmedabad is is \n gift city");  // \n for new line  
//            Console.WriteLine("Ahmedabad is is \t gift city");  // \t tab gove 8 space   




//            //------------------- revers sring ----------------------
//            string a;
//            Console.WriteLine("\n\nEnter the string");
//            a = Console.ReadLine();

//            for (int i = (a.Length) - 1; i >= 0; i--)
//            {
//                Console.Write(a[i]);
//            }

//            //------------------------------- Alternat of concatination ---------------------------------------
//            Console.WriteLine("\nEnter your name");
//            string name = Console.ReadLine();
//            Console.WriteLine("how mutch cansies you want");
//            string candies = Console.ReadLine();

//            Console.WriteLine($"your name is {name} you will get {candies} candies"); //alternate of + (conctination)
//                                                                                      // it is more readable 




//        }
//    }
//}
