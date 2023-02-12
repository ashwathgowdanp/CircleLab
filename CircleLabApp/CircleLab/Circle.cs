using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CircleLab
{
    public class Circle
    {
        private double radius;
        public Circle(double Radius)
        {
           
        }

        public double MyProperty 
        { 
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            } 
        }

        private string FormatNumber(double x)
        {
            double returnValue = Math.Round(x,2);
            return String.Format("{0:0.00}",returnValue);
        }
        public double CalculateCircumference() 
        {
            return (2 * Math.PI * radius);
        }
        public string CalculateFormattedCircumference()
        {
            double FormattedValue = CalculateCircumference();
            string CircumferenceValue = FormatNumber(FormattedValue);
            return CircumferenceValue;
        }
        public double CalculateArea()
        {

            return (Math.PI * radius * radius);
        }

        public string CalculateFormattedArea()
        {
            double FormattedValue = CalculateArea();
            string Area = FormatNumber(FormattedValue);
            return Area;
            
        }
    }
}
