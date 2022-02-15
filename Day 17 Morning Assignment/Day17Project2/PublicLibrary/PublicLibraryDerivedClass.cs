using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VamsiKrishnaLibrary;

namespace PublicLibrary
{
    public class PublicLibraryDerivedClass : BaseClass
    {
        public void PublicLibraryDerivedClassMethod()
        {
            a = 10;
            //b = 20;           private variable can't access here
            c = 30;
            //d = 40;           internal variable can't access here
            e = 50;
        }
    }
    public class PublicLibraryOtherClass
    {
        public void PublicLibraryOtherClassMethod()
        {
            BaseClass b = new BaseClass();
            b.a = 10;
            //b.b = 20;   private variable can't access here
            //b.c = 30;     Protected variable can't access here
            //b.d = 40;     internal variable can't access here
            //b.e = 50;        protected internal can't access here
        }
    }

}
