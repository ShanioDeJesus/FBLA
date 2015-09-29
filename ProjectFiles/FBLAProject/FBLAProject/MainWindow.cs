using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAProject
{
    public partial class MainWindow : Form
    {
        public HomeScreen home;

        public MainWindow()
        {
            InitializeComponent();
            loginInformation.loadSchools();
            theme.setTheme(Color.White, Color.FromArgb(34, 34, 34), Color.DarkRed, Color.Green);
            searchAndEdit1.parform = this;
            startScreen1.parform = this;
            homeScreen1.parform = this;
            menuSlideIn.Start();
            menuSlideOut.Start();
            startScreen1.Show();
            startScreen1.BringToFront();
            Padding = new Padding(0, 0, 0, 0);
            menuBar.Location = new Point(0, (this.ClientSize.Height - menuBar.Height) / 2);
        }

        private void MainWindow_ResizeBegin(object sender, EventArgs e)
        {
            SuspendLayout();
        }

        private void MainWindow_ResizeEnd(object sender, EventArgs e)
        {
            ResumeLayout(true);
            menuBar.Location = new Point(0, (this.ClientSize.Height - menuBar.Height) / 2);
        }
        public void hideAllPages()
        {
            foreach (UserControl u in this.Controls.OfType<UserControl>())
            {
                u.Hide();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void searchBtn_Click(object sender, EventArgs e)
        {
            foreach (UserControl c in this.Controls.OfType<UserControl>())
            {
                c.Hide();
            }
            searchAndEdit1.Show();
            searchAndEdit1.BringToFront();
            searchAndEdit1.Dock = DockStyle.Fill;
            menuBar.BringToFront();
            selectedBar.Location = new Point(selectedBar.Location.X, searchBtn.Location.Y);
         
        }


        private void menuBarAnimation_Tick(object sender, EventArgs e)
        {
            menuBar.BringToFront();

            if (MousePosition.X < this.PointToScreen(menuBar.Location).X + menuBar.Width + 1
             && MousePosition.X > this.PointToScreen(menuBar.Location).X - 1 && MousePosition.Y > this.PointToScreen(menuBar.Location).Y - 1 && MousePosition.Y < this.PointToScreen(menuBar.Location).Y + menuBar.Height + 1)
            {

                if (menuBar.Width >= 265)
                {
                }
                else
                {
                    menuBar.Width = 265;
                }

            }
        }

        private void menuSlideIn_Tick(object sender, EventArgs e)
        {
         chapterView.Hide();
            menuBar.BringToFront();
            if (MousePosition.X > this.PointToScreen(menuBar.Location).X + menuBar.Width
          || MousePosition.X < this.PointToScreen(menuBar.Location).X || MousePosition.Y < this.PointToScreen(menuBar.Location).Y || MousePosition.Y > this.PointToScreen(menuBar.Location).Y + menuBar.Height)
            {

                if (menuBar.Width <= 85)
                {
                }
                else
                {

                    menuBar.Width = 85;
                }
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {

        }

        private void exportBtn_Click(object sender, EventArgs e)
        {

        }

        private void importBtn_Click(object sender, EventArgs e)
        {

        }

        private void bulkBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            homeScreen1.Show();
            homeScreen1.reloadInfo();
            homeScreen1.BringToFront();
            homeScreen1.Dock = DockStyle.Fill;
            menuBar.BringToFront();
            selectedBar.Location = new Point(selectedBar.Location.X, viewAllBtn.Location.Y);

        }

        private void menuBar_Resize(object sender, EventArgs e)
        {
            if (menuBar.Width == 85)
            {
                menuBar.BackColor = Color.FromArgb(34, 34, 34);
            }
            else
            {
                menuBar.BackColor = Color.FromArgb(64, 64, 64);
            }

        }

        private void startScreen1_Load(object sender, EventArgs e)
        {

        }

        private void MainWindow_Move(object sender, EventArgs e)
        {
            menuBar.Location = new Point(0, (this.ClientSize.Height - menuBar.Height) / 2);
        }

        public static DataTable schoolTable = null;
        private void loadSchoolBack_DoWork(object sender, DoWorkEventArgs e)
        {
       
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            loginInformation.logOut();
        }

        private void saveMember_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void selectChapter_Click(object sender, EventArgs e)
        {
            chapterView.Show();
            chapterView.BringToFront();
        }
    }
}