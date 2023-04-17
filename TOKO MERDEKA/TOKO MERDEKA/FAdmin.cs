using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOKO_MERDEKA
{
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }

        void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new FManageUser());
        }
    }
}
