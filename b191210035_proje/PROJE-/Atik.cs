using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_
{
    //domates sinifi icin Iatik arayüzünü miras aldim.
     public class Domates:IAtik
    {
        private int _hacim;
        public int Hacim
        {
            get => _hacim; 
        }

        private Image _image;
        public Image Image
        {
            get => _image;
        }
     //domates icin degerleri atadim.
        public Domates()
        {
            _hacim = 150;
            _image = Image.FromFile("images//domates.jpg");
       
        }
            
    }
    //salatalik sinifi icin Iatik arayüzünü miras aldim.
    public class Salatalik : IAtik
    {
       
        private int _hacim;
        public int Hacim
        {
            get => _hacim;
        }

        private Image _image;
        public Image Image
        {
            get => _image;
        }
        //salatalik icin degerleri atadim.
        public Salatalik()
        {
            _hacim = 120;
            _image = Image.FromFile("images//sal.jpg");

        }

    }
    //sise sinifi icin Iatik arayüzünü miras aldim.
    public class Sise : IAtik
    {
        private int _hacim;
        public int Hacim
        {
            get => _hacim;
        }

        private Image _image;
        public Image Image
        {
            get => _image;
        }
        //sise icin degerleri atadim.
        public Sise()
        {
            _hacim = 600;
            _image = Image.FromFile("images//şişe.jpg");
        }

    }
    //bardak sinifi icin Iatik arayüzünü miras aldim.
    public class Bardak: IAtik
    {
        private int _hacim;
        public int Hacim
        {
            get => _hacim;
        }

        private Image _image;
        public Image Image
        {
            get => _image;
        }
        //bardak icin degerleri atadim.
        public Bardak()
        {
            _hacim = 250;
            _image = Image.FromFile("images//bardak.jpg");
     
        }

    }
    //gazete sinifi icin Iatik arayüzünü miras aldim.
    public class Gazete : IAtik
    {
        private int _hacim;
        public int Hacim
        {
            get => _hacim;
        }

        private Image _image;
        public Image Image
        {
            get => _image;
        }
        //gazete icin degerleri atadim.
        public Gazete()
        {
            _hacim = 250;
            _image = Image.FromFile("images//gazete.jpg");
 
        }

    }
    //dergi sinifi icin Iatik arayüzünü miras aldim.
    public class Dergi : IAtik
    {
        private int _hacim;
        public int Hacim
        {
            get => _hacim;
        }

        private Image _image;
        public Image Image
        {
            get => _image;
        }
        //dergi icin degerleri atadim.
        public Dergi()
        {
            _hacim = 200;
            _image = Image.FromFile("images//dergi.jpg");
        }

    }
    //cola sinifi icin Iatik arayüzünü miras aldim.
    public class Cola : IAtik
    {
        
        private int _hacim;
        public int Hacim
        {
            get => _hacim;
        }

        private Image _image;
        public Image Image
        {
            get => _image;
        }
        //cola icin degerleri atadim.
        public Cola()
        {
            _hacim = 350;
            _image = Image.FromFile("images//cola.jpg");
        }
   
      
    }
    //salca sinifi icin Iatik arayüzünü miras aldim.
    public class Salca : IAtik
    {
        private int _hacim;
        public int Hacim
        {
            get => _hacim;
        }

        private Image _image;
        public Image Image
        {
            get => _image;
        }
        //salca icin degerleri atadim.
        public Salca()
        {
            _hacim = 550;
            _image = Image.FromFile("images//salça.png");
        }
      
    }

}
