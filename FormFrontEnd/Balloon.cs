using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFrontEnd
{
    public class Balloon
    {
        private string colour;
        private decimal height;
        private decimal diameter;
        
        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                if (value.ToUpper() == "RED" || value.ToUpper() == "BLUE")
                {
                    colour = value;
                }
                else
                {
                    throw new DataException("Just kidding, Purple is cool too.");
                }
            }
        }

        public decimal Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public decimal Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
    }
}
