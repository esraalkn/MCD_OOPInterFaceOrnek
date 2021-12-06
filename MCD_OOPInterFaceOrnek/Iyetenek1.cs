using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterFaceOrnek
{
    interface Iyetenek1
    {
        //Interface'in kendi erişim belirleyicisi neyse içindeki elemanların hepsi aynı erişime sahiptir.
        //Bu nedenle interface içindeki elemanlara erişim belirleyicisi yazılmaz.
        //Interfacelerin metotlarının gövdesi olmaz.

        void X();//gövdesi yok.
        void Y();
        void Z();

    }
}
