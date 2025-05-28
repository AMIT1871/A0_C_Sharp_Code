////------------------------------- •	Hierarchical Inheritance ---------------------------------
//// class A
//// class B:A
//// class c:A     both derive classes accessing to base class(taking value from A class

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A0_C_Sharp_Code
//{
//    class A26_hierarchical_inheritance_A
//    {
//        protected int a = 300, b = 200, c;      //class variable by default private
//                                                //if you want to access in another class make them protected
//                                                //public void add()                       // methods should be publec then it will be accessable
//                                                //{                                       // void for no return

//        //}
//    }


//    class B : A26_hierarchical_inheritance_A
//    {
//        public void sub()
//        {
//            c = a - b;
//            Console.WriteLine("Subtraction " + c);
//        }
//    }


//    class C : A26_hierarchical_inheritance_A
//    {
//        public void dev()
//        {
//            c = a / b;
//            Console.WriteLine("Devision " + c);
//        }

//        public static void Main(String[] args)
//        {
//            C r = new C();                   // class C ka r object
//            B j = new B();                   // class B ka j object
//            j.sub();
//            r.dev();
//        }
//    }
//}