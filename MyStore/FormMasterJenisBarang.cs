using System;
using System.Windows.Forms;

using Barang;

namespace MyStore
{
    public partial class FormMasterJenisBarang : Form
    {
        public FormMasterJenisBarang()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            JenisBarang jenisBarang = new JenisBarang();
            jenisBarang.KodeJenis = Convert.ToInt32(txtKodeJenis.Text);
            jenisBarang.KeteranganJenis = txtKeterangan.Text;
            if (jenisBarang.DoCheckExist(jenisBarang) > 0)
            {
                MessageBox.Show("Kode Jenis : " + jenisBarang.KodeJenis + " Already exist. ");
            }
            else
            {
                if (jenisBarang.DoSave(jenisBarang) == true)
                {
                    MessageBox.Show("Record Saved");
                }
            }

        }

        private void txtKodeJenis_TextChanged(object sender, EventArgs e)
        {
            if (txtKodeJenis.Text.Trim() != string.Empty && txtKeterangan.Text.Trim() != string.Empty)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtKeterangan_TextChanged(object sender, EventArgs e)
        {
            if (txtKodeJenis.Text.Trim() != string.Empty && txtKeterangan.Text.Trim() != string.Empty)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtKodeJenis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }
}
