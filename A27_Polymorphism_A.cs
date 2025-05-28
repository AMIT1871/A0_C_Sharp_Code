//-----------------------Polymorphism------------------------------------------------------ -
//A.Compile time – Overloading
//B.Run Time – Overriding (through inheritance)

//•	Compile Time:-Before run the you also know which method(function)                                              will be run.
//•	Run-Time :-Before run the code you don’t know which method will be     run.




//----------------------------Compile Time Polymorphism -------------------------------------
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A0_C_Sharp_Code
//{
//    class A27_Polymorphism_A
//    {
//        int a = 20, b = 30;

//        public void add()
//        {
//            int sum = a + b;
//            Console.WriteLine(sum);
//        }

//        public void add(int a, int b)
//        {
//            int sum = a + b;
//            Console.WriteLine(sum);
//        }

//        public static void Main(String[] args)
//        {
//            A27_Polymorphism_A r = new A27_Polymorphism_A();  //class A25 ka object r
//            r.add();               //before running the code you know which method will execute
//            r.add(49, 50);         //its calles compile time polymorphism

//        }

//    }

//}



//-----------------------------Run Time Polymorphism ----------------------------------------
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A0_C_Sharp_Code
//{
//    class A27_Polymorphism_A
//    {
//        public virtual void sow()   // virtual not mandate just for dont show worning without this also run
//        {
//            Console.WriteLine("Amit");
//        }
//    }

//    class B : A27_Polymorphism_A
//    {
//        public override void sow()   // override not mandate just for dont show worning without this also run
//        {
//            base.sow();                    // phle base.sow likha hai to phle ye run hoga 
//            Console.WriteLine("Amit Kumar");
//        }
//    }

//    class main
//    {
//        public static void Main(String[] args)
//        {
//            B r = new B();   // B class ka object r
//            r.sow();         // before running youdont know which method will be run
//                             // class B ka method run hua kyoki vo phle likha hai depend on object belongs which class

//            // method ke nature se aap pta nahilga skte ki konsa run hoga
//            // it depends on object of whichclass
//            // or yh kewal inheritance me hi possible hai


//        }
//    }


//}
