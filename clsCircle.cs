using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_CS
{
    class clsCircle
    {
        private Decimal PI = Convert.ToDecimal(Math.PI);
        private Decimal decRadius = 0M;
        
        // Constructor
        public clsCircle()
        {
            decRadius = 0M;
        }

        public clsCircle(Decimal decRad, Decimal decHgh)
        {
            if (decRad >= 0M)
            {
                decRadius = decRad;
            }

        }
        //** Property
        public Decimal Radius
        {
            get
            {
                return decRadius;
            }
            set
            {
                if (value >= 0M)
                {
                    decRadius = value;
                }
            }
        }

        // Methods
        public Decimal Circumference()
        {
            return (PI * 2) * decRadius;
        }
       // 2 π r2 + 2 π r h
        public virtual Decimal Area()
        {
            return (decRadius * decRadius) * PI;
        }

        public virtual String Definition()
        {
            return "Circle: Area and Circumference";
        }
    }
}

