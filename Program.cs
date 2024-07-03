using Common;
using System.Drawing;
namespace Demo06
{
    internal class Program
    {
        /// <summary>
        /// Pros & cons >> according to memory Allocation
        /// pros: 1. quick to access its attributes as it in stack 
        ///       2. 
        /// cons: 1. if the object I will use it alot so I couldn't use it
        ///       2. his lifetime ends at the function end
        /// </summary>
       

        static void Main(string[] args)
        {
            // that if TypeA is public
            TypeA typeA = new TypeA();
            //typeA.y = 1; //is inaccessible due to its protection level as internal and it called in another project
            typeA.z =5;

            ////////////////////////

            Point p1;
            //Console.WriteLine(p1.y); // invalid before assign value to it >> as it is in garbage
            
            // by default the compilar will generate paramter less constructor 
            p1 = new Point(); // but new here is not the same with the new of class
            /// new class() ==>> 1. allocate required bytes in heap
            /// 2. intialize these bytes with the default value of it
            /// 3. call the constructor
            /// 4. make the reference refer to this object
            /// but in struct ==>> 1. which constructor to use to initialize (x ,y),,( Constructor selection) 
            

            Console.WriteLine(p1.x+ " "+ p1.y); // valid here 
            // Declare of object of type Point
            // CLR allocate 8 bytes uninitialized bytes at stack

            Point p2= new Point(100 ,5);
            Console.WriteLine(p1.ToString()); //Demo06.Point >> so we will override this method to return a value
            // after override tostring 
            Console.WriteLine(p1); // X = 100 , Y =0
            Console.WriteLine(p1.ToString()); // X = 100 , Y =0
            int number = 10;
            Console.WriteLine(number.ToString()); //10

        }
    }
}
