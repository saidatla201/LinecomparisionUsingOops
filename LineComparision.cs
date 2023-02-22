using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LineComparisionUsingOOps
{
    public class LineComparision
    {
        public void CoordinatesValues()
        {
            
            
                //  Co-ordinates
                Console.WriteLine("Enter the First line  Co-ordinates");
                Console.WriteLine("Enter the X1 value");
                double x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the X2 value");
                double x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Y1 value");
                double y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Y2 value");
                double y2 = Convert.ToInt32(Console.ReadLine());


                double lengthoffirstline = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                Console.WriteLine("Length of First line Co-ordinates" + lengthoffirstline);

                Console.WriteLine("Enter the Second line  Co-ordinates");
                Console.WriteLine("Enter the X3 value");
                double x3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the X4 value");
                double x4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Y3 value");
                double y3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Y4 value");
                double y4 = Convert.ToInt32(Console.ReadLine());


                double lengthofsecondline = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
                Console.WriteLine("Length of First line Co-ordinates" + lengthofsecondline);

            double outputvalue = lengthoffirstline.CompareTo(lengthofsecondline);
            if (outputvalue > 0)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else if (outputvalue < 0)
            {
                Console.WriteLine("Line 1 is less than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is equal to Line 2");
            }



        }
    }
}
