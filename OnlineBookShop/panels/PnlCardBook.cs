using OnlineBookShop.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookShop.panels
{
    public class PnlCardBook:Panel
    {
        private PictureBox picturebox;
        private Label lbltitle;
        private Label lblauthor;
        private Label lblprice;

        public PnlCardBook(Book book)
        {
            this.picturebox = new PictureBox();
            this.Controls.Add(this.picturebox);
            this.picturebox.Location = new System.Drawing.Point(0, 0);
            this.picturebox.Size=new System.Drawing.Size(110,160);

        }


    }
}
