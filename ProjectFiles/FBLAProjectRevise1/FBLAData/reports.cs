using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Collections;

namespace FBLAData
{
    public partial class reports : UserControl
    {
        public DataWindow thisWindow { get; set; }
        private DataSet dataSet { get; set; }
        public int reportCurrentChapter { get; set; }

        string memberCount { get; set; }
        string memberowing { get; set; }
        string activeMembers { get; set; }
        string totalowed { get; set; }
        string nonActiveMembers { get; set; }

        bool firstTimeView = true;
        public reports()
        {
            InitializeComponent();
            needToApply = false;
            documentTitleFont = new Font("Segoe UI", 14);
            documentHeaderFont = new Font("Segoe UI", 8);
            documentFont = new Font("Segoe UI", 8);

            TitleColor = new SolidBrush(Color.Black);
            HeaderColor = new SolidBrush(Color.Black);
            DocumentColor = new SolidBrush(Color.Black);
            HeaderBackColor = new SolidBrush(Color.LightGray);
            DocumentBorderColor = new SolidBrush(Color.LightGray);
            headerBox.Font = new Font("Segoe UI", 14);
            previewHeader.Font = new Font("Segoe UI", 8);
            previewDocument.Font = new Font("Segoe UI", 8);
            headerBox.ForeColor = Color.Black;
            previewHeader.ForeColor = Color.Black;
            previewDocument.ForeColor = Color.Black;
            previewBorder.BackColor = Color.LightGray;
            previewHeader.BackColor = Color.LightGray;

        }
        public void reloadInfo()
        {
            //To get the most accurate and up to date footer information, we retireve the information from viewAll footer labels
            memberCount = thisWindow.viewAllMembers.totalMembersLabel.Text;
            memberowing = thisWindow.viewAllMembers.membersOwingLabel.Text;
            activeMembers = thisWindow.viewAllMembers.activeMembersLabel.Text;
            totalowed = thisWindow.viewAllMembers.totalAmtLabel.Text;
            nonActiveMembers = thisWindow.viewAllMembers.nonActiveMembersLabel.Text;

            dataSet = null;
            dataSet = thisWindow.viewAllMembers.dataSet.Copy();
            if (reportCurrentChapter != thisWindow.CurrentChapter)
            {
                reportCurrentChapter = thisWindow.CurrentChapter;
                setReportType(0, "State", false);
            }

            if (firstTimeView == true)
            {
                printDocument1.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
                firstTimeView = false;
                viewTypeSelector.SelectedIndex = 0;
                setReportType(0, "State", false);
            }
            columnsToPrintBox.Items.Clear();
        }

        //THIS SECTION IS USED TO FORMAT PRINT===============================================================================================
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        int pageCount = 0; // USed to get page count

        //Used to customize document
        private Font documentHeaderFont { get; set; }
        private Font documentFont { get; set; }
        private Font documentTitleFont { get; set; }
        private Brush HeaderColor { get; set; }
        private Brush HeaderBackColor { get; set; }
        private Brush TitleColor { get; set; }
        private Brush DocumentColor { get; set; }
        private Brush DocumentBorderColor { get; set; }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                pageCount += 1;
                var dataTable = dataSet.Tables["mainTable"];
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                var subtitleFont = new Font(documentFont.FontFamily, 8);
                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataColumn GridCol in dataSet.Tables["mainTable"].Columns)
                    {
                        iTmpWidth = ((e.PageBounds.Width - e.PageSettings.Margins.Right - e.PageSettings.Margins.Left - 40) / dataSet.Tables["mainTable"].Columns.Count); // (int)(Math.Floor((double)((double) (e.PageSettings.PaperSize.Width /dataSet.Tables["mainTable"].Columns.Count) /

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.ColumnName,
                            documentHeaderFont, iTmpWidth).Height) + 11;

                        // Save width and height of headers; header is moved 40 to right for line numbering
                        arrColumnLefts.Add(iLeftMargin + 40);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dataTable.Rows.Count - 1)
                {
                    if (bNewPage)
                    {
                    }
                    else
                    {

                    }

                    DataRow GridRow = dataTable.Rows[iRow];
                    //Set the cell height
                    iCellHeight = documentFont.Height;
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
                            e.Graphics.DrawString("Page " + pageCount.ToString(), subtitleFont, TitleColor, new Point(e.PageBounds.Width - e.PageSettings.Margins.Right - Convert.ToInt32(e.Graphics.MeasureString("Page " + pageCount.ToString(), documentFont).Width), e.PageSettings.Margins.Top));

                            //Draw Title
                            e.Graphics.DrawString(headerBox.Text,
                                documentTitleFont,
                                TitleColor, e.MarginBounds.Left,
                                e.MarginBounds.Top);
                            //- e.Graphics.MeasureString(headerBox.Text,documentTitleFont, e.MarginBounds.Width).Height - 13
                            String strDate = DateTime.Now.ToLongDateString() + " " +
                                DateTime.Now.ToShortTimeString();
                            if (showDateCheck.Checked == true)
                            {
                                //Draw Date
                                e.Graphics.DrawString(strDate,
                                     subtitleFont, TitleColor,
                                    e.MarginBounds.Left +
                                    (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                     subtitleFont,
                                    e.MarginBounds.Width).Width),
                                    e.MarginBounds.Top + e.Graphics.MeasureString("Page", subtitleFont).Height);

                            }

                            //Draw Columns                 
                            iTopMargin = Convert.ToInt32(e.MarginBounds.Top + e.Graphics.MeasureString(headerBox.Text, documentTitleFont, e.MarginBounds.Width).Height + 13);
                            foreach (DataColumn GridCol in dataTable.Columns)
                            {

                                //myedit
                                e.Graphics.FillRectangle(HeaderBackColor,
                                                                  new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                                                  (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(new Pen(DocumentBorderColor),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.ColumnName,
                                     documentHeaderFont,
                                    HeaderColor, new RectangleF((int)arrColumnLefts[iCount], iTopMargin, (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;


                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                            if (showLineNumberCheck.Checked == true)
                            {
                                e.Graphics.DrawString(iRow.ToString(), documentFont, DocumentColor, new Point(e.PageSettings.Margins.Left, iTopMargin));
                            }
                        }
                        else
                        {
                            if (showLineNumberCheck.Checked == true)
                            {
                                e.Graphics.DrawString(iRow.ToString(), documentFont, DocumentColor, new Point(e.PageSettings.Margins.Left, iTopMargin));
                            }
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (object cel in GridRow.ItemArray)
                        {
                            if (cel != null)
                            {

                                e.Graphics.DrawString(cel.ToString(),
                                    documentFont,
                                    DocumentColor,
                                    new RectangleF((int)arrColumnLefts[iCount],
                                    (float)iTopMargin,
                                    (int)arrColumnWidths[iCount], (float)iCellHeight),
                                   strFormat);
                            }
                            //Drawing Cells Borders
                            e.Graphics.DrawRectangle(new Pen(DocumentBorderColor),
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iCellHeight));
                            iCount++;
                        }
                        //Draw Footer
                        //   string memberCount { get; set; }
                        //string memberowing { get; set; }
                        //string activeMembers { get; set; }
                        //string totalowed { get; set; }
                        //string nonActiveMembers { get; set; }

                        e.Graphics.DrawString(memberCount + "  " + memberowing + "  " + activeMembers + "  " + totalowed + "  " + nonActiveMembers, new Font(documentFont.FontFamily, 8),
DocumentColor, e.MarginBounds.Left,
                              e.MarginBounds.Bottom);

                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }
                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                {
                    //add to number of pages
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            pageCount = 0;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        ///Key Index, Layout type
        ///0 Full report
        /// 1 Members owing
        /// 2 High School Seniors
        /// 3 High School Juniors
        /// 4 High School Sopomores
        /// 5 High School Freshman
        /// 6 Emails
        /// 7 Active
        /// 8 Not active
        /// 9 Custom
        /// </summary>
        /// <param name="type"></param>
        public void setReportType(int type, string ColumnToSort, bool Descend, List<string> ListOfCustomColumnsToRemove = null)
        {
            try
            {
                //used for suffix  in title of document
                string titlesuf;
                reloadInfo();
                //Remove unmatching chapter numbers
                if (reportCurrentChapter != 0)
                {
                    var tempList = new List<DataRow>();
                    foreach (DataRow r in dataSet.Tables["mainTable"].Rows)
                    {
                        if (r.Field<string>("Chapter Number") != reportCurrentChapter.ToString())
                        {
                            tempList.Add(r);
                        }
                    }
                    foreach (DataRow r in tempList)
                    {
                        dataSet.Tables["mainTable"].Rows.Remove(r);
                    }
                    titlesuf = " | Chapter " + reportCurrentChapter.ToString();
                }
                else
                {
                    titlesuf = " | All Chapters";
                }
                //================================
                columnsToPrintBox.Hide();
                ColumnsToPrintLabel.Hide();

                if (type == 0)
                {
                    sortByBox.Items.Clear();
                    foreach (DataColumn c in dataSet.Tables["mainTable"].Columns)
                    {
                        sortByBox.Items.Add(c.ColumnName);
                    }
                    sortDocument(ColumnToSort, Descend);
                    headerBox.Text = "Full Report" + titlesuf;
                }
                if (type == 1)
                {
                    var tempList = new List<DataRow>();
                    // dataSet.Tables["mainTable"].Columns.Remove("State");
                    dataSet.Tables["mainTable"].Columns.Remove("Email");
                    dataSet.Tables["mainTable"].Columns.Remove("Active");
                    dataSet.Tables["mainTable"].Columns.Remove("Chapter Number");
                    foreach (DataRow r in dataSet.Tables["mainTable"].Rows)
                    {
                        if (r.Field<string>("Amount Owed") == "0")
                        {
                            tempList.Add(r);
                        }
                    }
                    foreach (DataRow r in tempList)
                    {
                        dataSet.Tables["mainTable"].Rows.Remove(r);
                    }
                    sortByBox.Items.Clear();
                    foreach (DataColumn c in dataSet.Tables["mainTable"].Columns)
                    {
                        sortByBox.Items.Add(c.ColumnName);
                    }
                    sortDocument(ColumnToSort, Descend);
                    headerBox.Text = "Members Owing Report" + titlesuf;
                }

                if (type == 2 || type == 3 || type == 4 || type == 5)
                {
                    int gr = 12;
                    if (type == 2)
                    {
                        gr = 12;
                    }
                    if (type == 3)
                    {
                        gr = 11;
                    }
                    if (type == 4)
                    {
                        gr = 10;
                    }
                    if (type == 5)
                    {
                        gr = 9;
                    }

                    var tempList = new List<DataRow>();
                    dataSet.Tables["mainTable"].Columns.Remove("Active");
                    dataSet.Tables["mainTable"].Columns.Remove("Chapter Number");
                    dataSet.Tables["mainTable"].Columns.Remove("Amount Owed");
                    dataSet.Tables["mainTable"].Columns.Remove("Membership Number");
                    dataSet.Tables["mainTable"].Columns.Remove("School");
                    foreach (DataRow r in dataSet.Tables["mainTable"].Rows)
                    {
                        if (r.Field<string>("Grade") != gr.ToString())
                        {
                            tempList.Add(r);
                        }
                    }
                    foreach (DataRow r in tempList)
                    {
                        dataSet.Tables["mainTable"].Rows.Remove(r);
                    }
                    dataSet.Tables["mainTable"].Columns.Remove("Grade");
                    sortByBox.Items.Clear();
                    foreach (DataColumn c in dataSet.Tables["mainTable"].Columns)
                    {
                        sortByBox.Items.Add(c.ColumnName);
                    }
                    sortDocument(ColumnToSort, Descend);
                    headerBox.Text = "Grade " + gr + " Report" + titlesuf;
                }
                if (type == 6)
                {
                    var tempList = new List<DataRow>();
                    dataSet.Tables["mainTable"].Columns.Remove("Active");
                    dataSet.Tables["mainTable"].Columns.Remove("Chapter Number");
                    dataSet.Tables["mainTable"].Columns.Remove("Amount Owed");

                    dataSet.Tables["mainTable"].Columns.Remove("School");
                    dataSet.Tables["mainTable"].Columns.Remove("Grade");
                    dataSet.Tables["mainTable"].Columns.Remove("Year Joined");
                    foreach (DataRow r in tempList)
                    {
                        dataSet.Tables["mainTable"].Rows.Remove(r);
                    }

                    sortByBox.Items.Clear();
                    foreach (DataColumn c in dataSet.Tables["mainTable"].Columns)
                    {
                        sortByBox.Items.Add(c.ColumnName);
                    }
                    sortDocument(ColumnToSort, Descend);
                    headerBox.Text = "Email Report" + titlesuf;
                }
                if (type == 7)
                {
                    var tempList = new List<DataRow>();
                    dataSet.Tables["mainTable"].Columns.Remove("Amount Owed");
                    dataSet.Tables["mainTable"].Columns.Remove("School");
                    foreach (DataRow r in dataSet.Tables["mainTable"].Rows)
                    {
                        if (r.Field<bool>("Active") == false)
                        {
                            tempList.Add(r);
                        }
                    }
                    foreach (DataRow r in tempList)
                    {
                        dataSet.Tables["mainTable"].Rows.Remove(r);
                    }

                    sortByBox.Items.Clear();
                    foreach (DataColumn c in dataSet.Tables["mainTable"].Columns)
                    {
                        sortByBox.Items.Add(c.ColumnName);
                    }
                    sortDocument(ColumnToSort, Descend);
                    headerBox.Text = "Non Active Members Report" + titlesuf;
                }
                if (type == 8)
                {
                    var tempList = new List<DataRow>();
                    dataSet.Tables["mainTable"].Columns.Remove("Amount Owed");
                    dataSet.Tables["mainTable"].Columns.Remove("School");
                    foreach (DataRow r in dataSet.Tables["mainTable"].Rows)
                    {
                        if (r.Field<bool>("Active") == true)
                        {
                            tempList.Add(r);
                        }
                    }
                    foreach (DataRow r in tempList)
                    {
                        dataSet.Tables["mainTable"].Rows.Remove(r);
                    }

                    sortByBox.Items.Clear();
                    foreach (DataColumn c in dataSet.Tables["mainTable"].Columns)
                    {
                        sortByBox.Items.Add(c.ColumnName);
                    }
                    sortDocument(ColumnToSort, Descend);
                    headerBox.Text = "Active Members Report" + titlesuf;
                }
                if (type == 9)
                {
                    columnsToPrintBox.Items.Clear();
                    sortByBox.Items.Clear();
                    foreach (DataColumn c in dataSet.Tables["mainTable"].Columns)
                    {
                        columnsToPrintBox.Items.Add(c.ColumnName, true);
                        sortByBox.Items.Add(c.ColumnName);
                    }
                    columnsToPrintBox.Show();
                    ColumnsToPrintLabel.Show();
                    sortDocument(ColumnToSort, Descend);
                    headerBox.Text = "Custom Report" + titlesuf;
                }

                //Remove custom columns
                if (ListOfCustomColumnsToRemove != null)
                {
                    sortByBox.Items.Clear();
                    columnsToPrintBox.Items.Clear();
                    foreach (DataColumn c in dataSet.Tables["mainTable"].Columns)
                    {
                        columnsToPrintBox.Items.Add(c.ColumnName, false);
                        sortByBox.Items.Add(c.ColumnName);
                    }
                    int i2;
                    foreach (string str in ListOfCustomColumnsToRemove)
                    {
                        dataSet.Tables["mainTable"].Columns.Remove(str);
                    }

                    for (i2 = 0; i2 < columnsToPrintBox.Items.Count; i2++)
                    {
                        if (dataSet.Tables["mainTable"].Columns.Contains(columnsToPrintBox.GetItemText(columnsToPrintBox.Items[i2])))
                        {
                            columnsToPrintBox.SetItemChecked(i2, true);
                        }
                    }
                    sortDocument(ColumnToSort, Descend);
                }
                needToApply = false;
                printCtrl.Document = printDocument1;
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Failed to load preset", "An error occured while loading this report type. Message: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
            }
        }

        private void typeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change the layout for print
            //Key Index, Layout type
            //0 Full report
            //1 Members owing
            //2 High School Seniors
            //3 High School Juniors
            //4 High School Sopomores
            //5 High School Freshman
            //6 Emails
            //7 Active
            //8 Not active
            //9 Custom
            setReportType(typeSelector.SelectedIndex, "State", false);
        }
        private void printBtn_Click(object sender, EventArgs e)
        {

        }
        //END FORMAT PRINT===============================================================================================
        //Print preview
        private void printPreviewBtn_Click(object sender, EventArgs e)
        {
            if (needToApply == true)
            {
                if (DialogResult.OK == new CustomMessageBox("Style changes", "There are style changes that have not been applied yet. Print anyways?", MessageBoxButtons.YesNo).ShowDialog())
                {
                    var prnt = new PrintDialog();
                    prnt.Document = printDocument1;
                    if (DialogResult.OK == prnt.ShowDialog())
                    {
                        printDocument1.DocumentName = "Report";
                        printDocument1.Print();
                    }
                }
            }
            else
            {
                var prnt = new PrintDialog();
                prnt.Document = printDocument1;
                if (DialogResult.OK == prnt.ShowDialog())
                {
                    printDocument1.DocumentName = "Report";
                    printDocument1.Print();
                }
            }


        }

        private void showPageSetup_Click(object sender, EventArgs e)
        {

            pageSetup.Document = printDocument1;
            if (DialogResult.OK == pageSetup.ShowDialog())
            {
                printDocument1.DefaultPageSettings = pageSetup.PageSettings;

            }
            applyDocumentChanges();
        }
        #region StyleEditor
        //Style editor
        bool needToApply = false;
        private void titleFontBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fontDialog1.ShowDialog())
            {
                if (fontDialog1.Font.Size > 32)
                {
                    new CustomMessageBox("Font Size Error", "Font size must be less than or equal to 28. Font size will be set to 28.", MessageBoxButtons.OK).ShowDialog();
                    documentTitleFont = new Font(fontDialog1.Font.FontFamily, 28);
                    headerBox.Font = new Font(fontDialog1.Font.FontFamily, 28);
                    needToApply = true;
                }
                else
                {
                    documentTitleFont = fontDialog1.Font;
                    headerBox.Font = fontDialog1.Font;
                    needToApply = true;
                }


            }

        }

        private void headerFontBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fontDialog1.ShowDialog())
            {
                documentHeaderFont = fontDialog1.Font;
                previewHeader.Font = fontDialog1.Font;
                needToApply = true;
            }
        }

        private void docFontBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fontDialog1.ShowDialog())
            {
                documentFont = fontDialog1.Font;
                previewDocument.Font = fontDialog1.Font;
                needToApply = true;
            }
        }

        private void titleColorBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                TitleColor = new SolidBrush(colorDialog1.Color);
                headerBox.ForeColor = colorDialog1.Color;
                needToApply = true;
            }
        }

        private void headerColorBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                HeaderColor = new SolidBrush(colorDialog1.Color);
                previewHeader.ForeColor = colorDialog1.Color;
                needToApply = true;
            }
        }

        private void docColorBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                DocumentColor = new SolidBrush(colorDialog1.Color);
                previewDocument.ForeColor = colorDialog1.Color;
                needToApply = true;
            }
        }

        private void borderColorBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                DocumentBorderColor = new SolidBrush(colorDialog1.Color);
                previewBorder.BackColor = colorDialog1.Color;
                needToApply = true;
            }
        }

        private void headerBackcolorBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                HeaderBackColor = new SolidBrush(colorDialog1.Color);
                previewHeader.BackColor = colorDialog1.Color;
                needToApply = true;
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            applyDocumentChanges();
        }
        private void applyDocumentChanges()
        {
            needToApply = false;
            try
            {
                int i2;
                List<string> temp = new List<string>();
                for (i2 = 0; i2 < columnsToPrintBox.Items.Count; i2++)
                {
                    if (columnsToPrintBox.GetItemCheckState(i2) == CheckState.Unchecked)
                    {
                        temp.Add(columnsToPrintBox.Items[i2].ToString());
                    }
                }
                setReportType(typeSelector.SelectedIndex, sortByBox.SelectedItem.ToString(), decendOrder.Checked, temp);
            }
            catch
            {

            }
            printCtrl.Document = printDocument1;
        }
        private void defaultValues_Click(object sender, EventArgs e)
        {
            needToApply = true;
            documentTitleFont = new Font("Segoe UI", 14);
            documentHeaderFont = new Font("Segoe UI", 8);
            documentFont = new Font("Segoe UI", 8);

            TitleColor = new SolidBrush(Color.Black);
            HeaderColor = new SolidBrush(Color.Black);
            DocumentColor = new SolidBrush(Color.Black);
            HeaderBackColor = new SolidBrush(Color.LightGray);
            DocumentBorderColor = new SolidBrush(Color.LightGray);
            headerBox.Font = new Font("Segoe UI", 14);
            previewHeader.Font = new Font("Segoe UI", 8);
            previewDocument.Font = new Font("Segoe UI", 8);
            headerBox.ForeColor = Color.Black;
            previewHeader.ForeColor = Color.Black;
            previewDocument.ForeColor = Color.Black;
            previewBorder.BackColor = Color.LightGray;
            previewHeader.BackColor = Color.LightGray;
            showLineNumberCheck.Checked = true;
            showDateCheck.Checked = true;
        }
        #endregion
        private void zoomInBtn_Click(object sender, EventArgs e)
        {
            printCtrl.Zoom += .1;
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
        int currentPage = 0;
        private void prePageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                printCtrl.StartPage -= 1;
                pgNumberLabel.Text = "Page " + (printCtrl.StartPage + 1) + " of " + pageCount.ToString();
            }
            catch
            {

            }

        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                printCtrl.StartPage += 1;
                pgNumberLabel.Text = "Page " + (printCtrl.StartPage + 1) + " of " + pageCount.ToString();

            }
            catch
            {

            }

        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            pgNumberLabel.Text = "Page 1 of " + pageCount.ToString();
        }
        private void sortDocument(string Sort, bool Descend)
        {
            try
            {
                needToApply = true;
                DataTable dt;


                if (Descend == false)
                {
                    dataSet.Tables["mainTable"].DefaultView.Sort = Sort + " ASC";
                    dt = dataSet.Tables["mainTable"].DefaultView.ToTable();
                    dataSet.Tables.Remove("mainTable");
                    dataSet.Tables.Add(dt);
                    dontSort = true;
                    sortByBox.SelectedItem = Sort;
                    decendOrder.Checked = false;
                    dontSort = false;
                }
                else
                {
                    dataSet.Tables["mainTable"].DefaultView.Sort = Sort + " DESC";
                    dt = dataSet.Tables["mainTable"].DefaultView.ToTable();
                    dataSet.Tables.Remove("mainTable");
                    dataSet.Tables.Add(dt);
                    dontSort = true;
                    sortByBox.SelectedItem = Sort;
                    decendOrder.Checked = true;
                    dontSort = false;
                }
            }
            catch { }

        }

        bool dontSort = true;
        private void sortByBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontSort == false)
            {
                sortDocument(sortByBox.SelectedItem.ToString(), false);
            }

        }

        private void viewCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            needToApply = true;
        }

        private void toolPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void decendOrder_CheckedChanged(object sender, EventArgs e)
        {
            needToApply = true;
        }
    }
}
