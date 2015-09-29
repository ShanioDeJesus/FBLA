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
    public partial class EditExisitingMembership : UserControl
    {
        public EditExisitingMembership()
        {
            InitializeComponent();
        }

        private void EditExisitingMembership_Leave(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
