using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math
{
    public partial class  Primative
    {
        public int dn1;
        public int dn2;

        public Primative()
        {
            dn1 = 15 * 15;
            dn2 = 25 * 25;
        }

        public long Add()
        {
            return dn1 + dn2;
        }

        public long Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public Decimal Add(long n1, long n2)
        {
            return n1 + n2;
        }

        public long Add(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }


        public virtual long Dec(int n1, int n2)
        {
            return n1 * n2;
        }
    }


    public class Primative1 :  Primative
    {
        public override long Dec(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
