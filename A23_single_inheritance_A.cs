//////------------------------ inheritance -----------------------------------------
//////Is a process of deriving properties of one class to another class. 
//////•	We can reuse the variable and methods of the existing class.
//////•	Sub class -Which inherit the properties 
//////•	Base class – Whose properties are inherited
////// use for code reusability
//////
//////•	Single Inheritance
//////•	Multi-Level Inheritance
//////•	Multiple Inheritance
//////•	Hierarchical Inheritance


////    //--------------------------- single inheritance -------------------------------------------------
////    // class A a+b/ a-b
////    // class B a*b/ a/b   class b print all statements

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A0_C_Sharp_Code
//{
//    internal class A23_single_inheritance_A
//    {
//        protected int a = 300, b = 200, c;      //class variable by default private
//                                                //if you want to access in another class make them protected

//        public void add()                       // methods should be publec then it will be accessable
//        {                                       // void for no return
//            c = a + b;
//            Console.WriteLine("Addition " + c);
//        }

//        public void sub()
//        {
//            c = a - b;
//            Console.WriteLine("Subtraction " + c);
//        }
//    }


//    class B : A23_single_inheritance_A       //class b accessing class A21_inheritance_A
//    {

//        public void dev()
//        {
//            c = a / b;
//            Console.WriteLine("Devision " + c);

//        }

//        public void multi()
//        {
//            c = a * b;
//            Console.WriteLine("Multiplication " + c);

//        }


//        public static void Main(String[] args)
//        {

//            B r = new B();                //class B ka object r 

//            r.add();                      // class B ke object se Class A ke method ko access kr rahe hai
//            r.sub();
//            r.multi();
//            r.dev();

//        }

//    }
//}
