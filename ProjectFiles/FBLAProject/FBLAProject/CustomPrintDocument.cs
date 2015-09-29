using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAProject
{
    public class CustomPrintDocument : PrintDocument
    {
        private ListView _listView;
        public ListView ListView
        {
            get { return _listView; }
            set
            {
                _listView = value;
                if (value != null)
                {
                    this.PrintPage += CPrintPage;
                }
            }
        }

        //You can have your way of decoration </strong></em>
        void CPrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;


            var font = new Font("Arial", 10);

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height / font.GetHeight(ev.Graphics);

            // Print each line of the file.
            foreach (ListViewItem item in ListView.Items)
            {
                yPos = topMargin + (count * font.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(item.Text, font, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            ev.HasMorePages = false;
        }
    }
}
