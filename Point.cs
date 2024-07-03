using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06
{
    //public or internal
    struct Point
    {
        ///1. Attributes
        ///

        public double x;
        public double y;

        /// Functions 
        /// special function [Constructors] 
        /// 1. named always with the same name of struct name or the class name
        /// benefits of struct:
        /// 1.has no return
        /// 2.initialize for attributes
        ///

        /// Allowed Access modifiers >> public / internel
        /// we can use >> Private >> only if we will use [singlton Dp] >>> this class we ant to create one object only from it
        /// takes parameters or not
        /// 

        public Point()
        {
            x=100;
            y=default;
        }

        //initialize for attributes
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public Point(double _x, int _y)
        {
            x = _x;
            y = _y;
        }

        // OR
        //public Point(int x, int y)  // in .net6.00
        //{
        //    this.x = x;
        //    this.y = y;
        //}

        // Constructor overloading == >>  عددهم و ترتيب و نوع المتغيرات
        public Point(int num)
        {
            x = y = num;
        }

        //public Point(int _x, string _y) // invalid
        //{
        //    x = _x;
        //    y = _y;
        //}
        //public Point(string _x, int _y)  // invalid
        //{
        //    x = _x;
        //    y = _y;
        //}

      
      
        // overloading of ToString() method to retrieve the actual data
        public override string ToString() {
            return $"X = {x} , Y ={y}";
        }

        // that is tha default of tostring();
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
