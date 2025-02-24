using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai12_Listbox_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            lstNames.Items.Add(txtName.Text);
            txtName.Text = "";
            txtName.Focus();

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex < 0)
                lstNames.Items[lstNames.SelectedIndex] = txtName.Text;
            MessageBox.Show("Hãy chọn tên trong danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            return;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            lstNames.Items.Add("Trần Văn A");
            lstNames.Items.Add("Trần Văn B");
            lstNames.Items.Add("Trần Văn C");
            lstNames.Items.Add("Trần Văn D");
            lstNames.Items.Add("Trần Văn E");
            lstNames.Items.Add("Trần Văn F");
            lstNames.Items.Add("Trần Văn G");
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            {
                return;
            }
            txtName.Text = lstNames.SelectedIndex.ToString();
        }
    }
}
