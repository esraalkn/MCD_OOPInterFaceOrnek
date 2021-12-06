using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterFaceOrnek
{
    class Ogrenci : Insan, Iyetenek1, Iyetenek2
    {
        void Iyetenek2.A()
        {
            throw new NotImplementedException();
        }

        void Iyetenek2.B()
        {
            throw new NotImplementedException();
        }
        //Bir class ve bir interface den kalıtım almamız gerektiğinde 
        //Önce class sonra interface yazılır.

        //Bir class bir class dan kalıtım alır. (Önemli! birden fazla olmaz)
        //Bir class birden çok interfaceden kalıtım alabilir.
        void Iyetenek1.X()
        {
            throw new NotImplementedException();
        }

        void Iyetenek2.X()
        {
            throw new NotImplementedException();
        }

        void Iyetenek1.Y()
        {
            throw new NotImplementedException();
        }

        void Iyetenek1.Z()
        {
            throw new NotImplementedException();
        }
    }
}
