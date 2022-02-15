using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamsiKrishnaLibrary
{
    public class BaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;

        public void BaseClassMethod()
        {
            a = 10;
            b = 20;
            c = 30;
            d = 40;
            e = 50;
        }



    }
    public class DerivedClass : BaseClass
    {
        public void DerivedClassMethod()
        {
            a = 10;
            //b = 20;                  //Private variable can't access here
            c = 30;
            d = 40;
            e = 50;
        }
    }
    public class OtherClass
    {
        public void OtherClassMethod()
        {
            BaseClass b = new BaseClass();
            b.a = 10;
            //b.b = 20;     Private variable can't access here
            //b.c = 30;     protected variable can't acess here
            b.d = 40;
            b.e = 50;
        }
    }
}
