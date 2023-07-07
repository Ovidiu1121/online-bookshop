using OnlineBookShop.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookShop.panels
{
    public class PnlSlideShow : Panel
    {
        List<Imagini> imagini = new List<Imagini>();
        private int index = -1;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public PnlSlideShow()
        {
            loadImagini();

            t.Interval=3000;
            t.Tick+=(a, b) =>
            {
                if (index<imagini.Count-1)
                {
                    index++;
                    loadForIndex();
                }
                else
                {
                    index=1;
                    loadForIndex();
                }
            };
            t.Start();
        }

        public void loadImagini()
        {
            imagini=new List<Imagini>();

            string[] input = { "1", "2", "3", "4" };
            List<string> lista = new List<string>(input);

            foreach (string s in lista)
            {
                imagini.Add(new Imagini
                {
                    Path=s.ToString(),
                });
            }

            if (imagini.Count>0&&index==-1)
            {
                index=0;
            }


            loadForIndex();
        }

        public void loadForIndex()
        {
            this.BackgroundImage=Image.FromFile(Application.StartupPath+@"\imagini\"+imagini[index].Path+".jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}

