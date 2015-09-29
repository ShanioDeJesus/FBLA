using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace FBLAData
{
    public partial class customPrintPreview : Form
    {
        public PrintDocument Document { get; private set; }

        public customPrintPreview(PrintDocument doc)
        {
            InitializeComponent();
            var br = new customBorder(this, titleBar, topBorder, leftBorder, rightBorder, bottomBorder, maxrestoreBtn, Properties.Resources.max1, Properties.Resources.restore1, toprightresize, topleftresize, bottomrightresize, bottomleftresize);
            Document = doc;
            Document.PrintPage += printPage;
            printCtrl.Document = Document;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zoomInBtn_Click(object sender, EventArgs e)
        {
            printCtrl.Zoom += .11;
        }

        private void zoomOutBtn_Click(object sender, EventArgs e)
        {
            if (printCtrl.Zoom > 0)
            {
                printCtrl.Zoom -= .1;
            }

        }

        private void viewTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index, page type
            //0 = one page view
            //1 = two page view
            //2 = three page view
            //3 = four page view
            if (viewTypeSelector.SelectedIndex == 0)
            {
                printCtrl.Columns = 1;
                printCtrl.Rows = 1;
            }
            if (viewTypeSelector.SelectedIndex == 1)
            {
                printCtrl.Columns = 2;
                printCtrl.Rows = 1;
            }
            if (viewTypeSelector.SelectedIndex == 2)
            {
                printCtrl.Columns = 2;
                printCtrl.Rows = 2;
            }
            if (viewTypeSelector.SelectedIndex == 3)
            {
                printCtrl.Columns = 2;
                printCtrl.Rows = 2;
            }
        }

        int currentPage = 1;
        int pageCount = 0;
        private void prePageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPage > 1)
                {
                    currentPage -= 1;
                    pgNumberLabel.Text = "Page" + currentPage + " of " + pageCount.ToString();
                    printCtrl.StartPage -= 1;
                }
            }
            catch
            {

            }

        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPage < pageCount)
                    currentPage += 1;
                pgNumberLabel.Text = "Page " + currentPage + " of " + pageCount.ToString();
                printCtrl.StartPage += 1;
            }
            catch
            {

            }

        }

        //This is used to count pages
        private void printPage(object sender, PrintPageEventArgs e)
        {
            pageCount += 1;
            pgNumberLabel.Text = "Page 1 of " + pageCount.ToString();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            var prnt = new PrintDialog();
            prnt.Document = Document;
            if (DialogResult.OK == prnt.ShowDialog())
            {
                Document.PrintPage -= printPage;
                Document.DocumentName = "Report";
                Document.Print();
            }

        }
    }

}
