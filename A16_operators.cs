////--------------------- arthmetic / Relational ---------------------------------------
//// Arithmetic operator  +, -, *, /, %(modulas)
//// Relational operator  <, >, <=, >=
//// Assignment operator  =
//// Equality operator    ==, !=
//// Logical operator     !, &&, ||, |
//// Ternary operator     ? :              (find grater value)
//// Increment/decrement   i++, ++i,  i--, --i



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A0_C_Sharp_Code
//{
//    internal class A16_operators
//    {
//        public static void Main(String[] args)
//        {
//            int a, b;
//            Console.WriteLine("Enter the value of a and b");
//            a = Convert.ToInt32(Console.ReadLine());
//            b = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("a = " + a);
//            Console.WriteLine("b = " + b);


//            Console.WriteLine("Arithmetic operator \n");
//            Console.WriteLine("a+b = " + (a + b));  //+a+b gives wrong ans
//            Console.WriteLine("a-b = " + (a - b));
//            Console.WriteLine("a*b = " + a * b);
//            Console.WriteLine("a/b = " + a / b);
//            Console.WriteLine("a%b = " + a % b);  //modules / get remainder


//            Console.WriteLine("\n\n Relational operator \n");
//            Console.WriteLine("a<b = " + (a < b));
//            Console.WriteLine("a>b = " + (a > b));
//            Console.WriteLine("a<=b = " + (a <= b));
//            Console.WriteLine("a>=b = " + (a >= b));


//            Console.WriteLine("\n\n Equality operator \n");
//            Console.WriteLine("a==b = " + (a == b));
//            Console.WriteLine("a!=b = " + (a != b));


//            Console.WriteLine("\n\n Logical operator \n");
//            Console.WriteLine("a<b && a>b = " + (a < b && a > b));  //any one false so output false
//            Console.WriteLine("a<b || a>b = " + (a < b || a > b));  //any one true so output true
//            Console.WriteLine("!a<b = " + !(a < b));


//            Console.WriteLine("\n\n Ternary operator \n");
//            int r = (a > b) ? a : b;                            // find grater value
//            Console.WriteLine("Grater value is = " + r);


//            Console.WriteLine("\n\n Increment/decrement operator \n");
//            Console.WriteLine("a++ = " + (a++));  //12
//            Console.WriteLine("++a = " + (++a));  // 14
//            Console.WriteLine("a-- = " + (a--));  // 14
//            Console.WriteLine("--a = " + (--a));  // 12




//        }
//    }
//}
