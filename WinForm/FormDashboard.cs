using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormDashboard : Form
    {
        public string username;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            lblName.Text = username;
        }
    }
}
