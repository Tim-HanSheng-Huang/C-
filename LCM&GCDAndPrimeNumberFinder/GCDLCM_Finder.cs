using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09725060HSHAss06
{
    class GCDLCM_Finder
    {
        //data O-O data encapsulation
        private long a=66, b=98;

        public void SetA(int aa)
        {
            if (aa == 0)
                a = aa;
        }

        public long GetA()
        {
            return this.a;
        }


        //propertyA
        public long Number1
        {
            //at least one setter or getter
            get
            {
                return a;
            }
            set
            {
                if (value != 0)
                    a = value;
            }
        }

        //propertyB
        public long Number2
        {
            //at least one setter or getter
            get
            {
                return b;
            }
            set
            {
                if (value != 0)
                    b = value;
            }
        }

        //methods
        public bool SetOperands(long aa, long bb)
        {
            //validity checking
            if (aa == 0 || bb == 0)
                return false;
            this.a = aa;
            this.b = bb;
            return true;
        }

        public long GetLCM()
        {
            long lcm = 0;
            lcm = a * b / GetGCD();
            return lcm;
        }

        public long GetGCD()
        {
            long l = Math.Max(a, b);
            long s = Math.Min(a, b);
            long m = l % s;
            while(m!=0)
            {
                l = s;
                s = m;
                m = l % s;
            }

            long gcd = s;

            return gcd;
        }
    }
}
