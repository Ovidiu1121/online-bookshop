using OnlineBookShop.forms;
using OnlineBookShop.models;
using OnlineBookShop.repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookShop.panels
{
    public class PnlChooseGenre:Panel
    {
        private FrmHome frmhome;
        private ComboBox cmb;
        private BookRepository controlBook=new BookRepository();

        public PnlChooseGenre(FrmHome frmhome)
        {
            this.frmhome = frmhome;

            this.Location =new Point(0, 70);
            this.Size =new Size(1950, 40);
            this.BackColor = Color.Green;
            this.Name="pnlchoosegenre";

            this.cmb = new ComboBox();
            this.Controls.Add(this.cmb);
            this.cmb.Location = new Point(27, 9);
            this.cmb.Size = new Size(300, 24);
            this.cmb.Font=new Font("Arial", 10, FontStyle.Regular);
            this.cmb.Text="Genres";
            populateCmbBox();

        }

        private void populateCmbBox()
        {

            List<string> categories = this.controlBook.getAllGenres();

            foreach (string category in categories)
            {
                this.cmb.Items.Add(category);
            }

        }

    }
}
