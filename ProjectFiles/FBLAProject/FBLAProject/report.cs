using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//MY PERSONAL NOTES
//I GOT THE PRIN CODE FROM http://www.codeproject.com/Articles/28046/Printing-of-DataGridView
//I EDITED TO FIT MY NEEDS
//ADD THE LICENCE TO INSTALLER
namespace FBLAProject
{
    public partial class report : Form
    {
        public report(DataGridView DataGridView)
        {
            InitializeComponent();
            foreach (DataGridViewColumn c in DataGridView.Columns)
            {
                thisGrid.Columns.Add(c.Clone() as DataGridViewColumn);
            }
   
            DataGridViewRow row = new DataGridViewRow();

            for (int i = 0; i < DataGridView.Rows.Count; i++)
            {
                row = (DataGridViewRow)DataGridView.Rows[i].Clone();
                int intColIndex = 0;
                foreach (DataGridViewCell cell in DataGridView.Rows[i].Cells)
                {
                    row.Cells[intColIndex].Value = cell.Value;
                    intColIndex++;
                }
                row.Height = 15;
               thisGrid.Rows.Add(row);
            }
            thisGrid.Columns.Remove("ID");
        }

        private void report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Report";
                printDocument1.Print();
            }

        }

        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in thisGrid.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                            (double)iTotalWidth * (double)iTotalWidth *
                            ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                            GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headers
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= thisGrid.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = thisGrid.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allows more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString(textBox1.Text,
                                new Font("Times New Roman", 14),
                                Brushes.Black, e.MarginBounds.Left,
                                e.MarginBounds.Top - e.Graphics.MeasureString(textBox1.Text,
                                new Font("Times New Roman", 14),
                                e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " +
                                DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate,
                                new Font("Times New Roman", 14), Brushes.Black,
                                e.MarginBounds.Left +
                                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                new Font("Times New Roman", 14),
                                e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString(textBox1.Text,
                                new Font(new Font("Times New Roman", 14),
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in thisGrid.Columns)
                            {
                                //myedit
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                                                  new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                                                  (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;


                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(),
                                    Cel.InheritedStyle.Font,
                                    new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount],
                                    (float)iTopMargin,
                                    (int)arrColumnWidths[iCount], (float)iCellHeight),
                                    strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iCellHeight));
                            iCount++;
                        }
                        //Draw Footer (My Edit)
                        e.Graphics.DrawString("Test",
                              new Font("Times New Roman", 10),
                              Brushes.Black, e.MarginBounds.Left,
                              e.MarginBounds.Bottom - e.Graphics.MeasureString("Test",
                              new Font("Times New Roman", 10),
                              e.MarginBounds.Width).Height + 13);

                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }
                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in thisGrid.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            thisGrid.Columns[0].Visible = false;
        }

        private void loadReport_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
