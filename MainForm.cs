using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSudokuSolver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonChoosePicture_Click(object sender, EventArgs e)
        {
            if(openFileDialogPicture.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {

        }
    }
}
