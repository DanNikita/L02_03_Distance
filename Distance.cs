using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    internal class Distance
    {
        public struct royalDim
        {
            public int foot;
            public int inch;
        }
        public static royalDim valueCheck(royalDim v)
        {
            if (v.inch < 12)
                {
                Console.WriteLine("Original value");
                Console.WriteLine(v.foot);
                Console.WriteLine(v.inch);
                return v;   
                }
            else              
            {
                royalDim n;
                n.foot = v.foot + v.inch / 12;
                n.inch = v.inch % 12;
                Console.WriteLine("Updated value");
                Console.WriteLine(n.foot);
                Console.WriteLine(n.inch);
                return n;  
            }
        }
        static void Main(string[] args)
        {
            royalDim a, b, c;
            Console.WriteLine("Enter first distance");
            Console.Write("Enter inch value:");
            a.inch = int.Parse(Console.ReadLine());
            Console.Write("Enter foot value:");
            a.foot = int.Parse(Console.ReadLine());
            a = valueCheck(a);
            Console.WriteLine("First distance: {0} Feet, {1} Inches", a.foot,  a.inch);
            Console.WriteLine("Enter second distance");
            Console.Write("Enter inch value:");
            b.inch = int.Parse(Console.ReadLine());
            Console.Write("Enter foot value:");
            b.foot = int.Parse(Console.ReadLine());
            b = valueCheck(b);
            Console.WriteLine("Second distance: {0} Feet, {1} Inches", b.foot, b.inch);
            c.inch = a.inch + b.inch;
            c.foot = a.foot + b.foot;
            c = valueCheck(c);
            Console.WriteLine("Summary distance: {0} Feet, {1} Inches", c.foot, c.inch);
            Console.ReadLine();    
        }
    }
}
