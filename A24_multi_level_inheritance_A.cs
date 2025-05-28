////////--------------------------- Multi level inheritance --------------------------------------
//// class A
//// Class B:A
//// Class c:B   // class C able to access all calsses

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A0_C_Sharp_Code
//{
//    class A24_multi_level_inheritance_A
//    {
//        protected int a = 300, b = 200, c;      //class variable by default private
//                                                //if you want to access in another class make them protected

//        public void add()                       // methods should be publec then it will be accessable
//        {                                       // void for no return
//            c = a + b;
//            Console.WriteLine("Addition " + c);
//        }
//    }

//    class B : A24_multi_level_inheritance_A      //class b accessing calss A
//    {
//        public void sub()
//        {
//            c = a - b;
//            Console.WriteLine("Subtraction " + c);
//        }
//    }


//    class C : B                                  //class C accessing calss B
//    {
//        public void dev()
//        {
//            c = a / b;
//            Console.WriteLine("Devision " + c);
//        }


//        public static void Main(String[] args)
//        {
//            C r = new C();                     //C calass ka object access all calsses
//            r.add();
//            r.sub();
//            r.dev();
//        }


//    }
//}