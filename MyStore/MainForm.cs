using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyStore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void jenisBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterJenisBarang FormJenisBarang = new FormMasterJenisBarang();
            FormJenisBarang.MdiParent = this;
            FormJenisBarang.Show();
        }
    }
}
