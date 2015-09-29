using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAProject
{
    public partial class startScreen : UserControl
    {
        public MainWindow parForm;
        public MainWindow parform
        {
            get
            {
                return parForm;
            }
            set
            {
                parForm = value;
            }
        }
        public startScreen()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            parform.searchAndEdit1.BringToFront();
            parform.Padding = new Padding(95, 0, 0, 0);
            parform.menuBar.Location = new Point(0, (this.ClientSize.Height - parform.menuBar.Height) / 2);
            parform.menuBar.Show();
        }

        private void newMemberBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {

        }

        private void importBtn_Click(object sender, EventArgs e)
        {

        }

        private void exportBtn_Click(object sender, EventArgs e)
        {

        }

        private void bulkBtn_Click(object sender, EventArgs e)
        {

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void startScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
