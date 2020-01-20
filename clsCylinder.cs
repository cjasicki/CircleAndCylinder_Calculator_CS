using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_CS
{
    class clsCylinder : clsCircle 
    {
        Decimal decHeight = 0.0M;
        public clsCylinder()  //Default constructor
    : base()
        {
            decHeight = 0M;
        }
        public clsCylinder(Decimal decRad,  Decimal decHgt)
    : base(decRad, decHgt) //Calls the constructor for inherited class                           
        {
            if (decHgt >= 0M)
            {
                decHeight = decHgt;
            }
        }
        //** Property
        public Decimal Height
        {
            get
            {
                return decHeight;
            }
            set
            {
                if (value >= 0M)
                {
                    decHeight = value;
                }
            }
        }
        //** Method
        public Decimal Volume()
        {
            return (base.Area() * Height);
        }
        public override Decimal Area() 
        {
            //2 π r2 + 2 π r h
            return base.Area() + (Height * base.Circumference());
        }
        public override String Definition()
        {
            return "Cylinder: Volume and Surface Area";
        }
    }
}

