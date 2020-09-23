using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_
{ 
    //Kullanacagim arayüzleri olusturdum.
    public interface IAtik
    {
        int Hacim { get; }
        System.Drawing.Image Image { get; }
    }

    public interface IAtikKutusu:IDolabilen
    {
        int bosaltmaPuani { get; }
   
    }
    public interface IDolabilen
    {
        int kapasite { get; set; }
     
    }
}
