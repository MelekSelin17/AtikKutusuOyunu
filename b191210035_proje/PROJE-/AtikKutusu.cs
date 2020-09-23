using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_
{
    //OrganikAtik sinifi IatikKutusu arayüzünden miras aldi.
   public class OrganikAtik : IAtikKutusu
    {
    

        private int _bosaltmaPuani;
        public int bosaltmaPuani => _bosaltmaPuani;

        private int _kapasite;
        public int kapasite { get => _kapasite; set => throw new NotImplementedException(); }


     //degerleri atadim.
        public OrganikAtik()
        {
            _bosaltmaPuani = 0;
            _kapasite = 700;
       
           
        }
    }
    //Kagit sinifi IatikKutusu arayüzünden miras aldi.
    public class Kagit : IAtikKutusu
    {

        private int _bosaltmaPuani;
        public int bosaltmaPuani => _bosaltmaPuani;

        private int _kapasite;
        public int kapasite { get => _kapasite; set => throw new NotImplementedException(); }


        //degerleri atadim.
        public Kagit()
        {
            _bosaltmaPuani = 1000;
            _kapasite = 1200;
        }
    }
    //Metal sinifi IatikKutusu arayüzünden miras aldi.
    public class Metal : IAtikKutusu
    {

        private int _bosaltmaPuani;
        public int bosaltmaPuani => _bosaltmaPuani;

        private int _kapasite;
        public int kapasite { get => _kapasite; set => throw new NotImplementedException(); }


        //degerleri atadim.
        public Metal()
        {
            _bosaltmaPuani = 800;
            _kapasite = 2300;
        }
    }
    //Cam sinifi IatikKutusu arayüzünden miras aldi.
    public class Cam : IAtikKutusu
    {

        private int _bosaltmaPuani;
        public int bosaltmaPuani => _bosaltmaPuani;

        private int _kapasite;
        public int kapasite { get => _kapasite; set => throw new NotImplementedException(); }


        //degerleri atadim.
        public Cam()
        {
            _bosaltmaPuani = 600;
            _kapasite = 2200;
        }
    }

}
