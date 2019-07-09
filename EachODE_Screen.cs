using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRFNprojectJULY2019proj
{
    public partial class EachODE_Screen : Form
    {
        /// <summary>
        /// Summary of the description of the method defined ahead
        /// </summary>
        public EachODE_Screen()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_EODE_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_EODE_add_Click(object sender, EventArgs e)
        {
            SRFNprojectJULY2019proj.Program.NumOperationsAdded = 1;
            this.Close();
        }
    }
}
