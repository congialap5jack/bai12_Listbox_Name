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
        List<string> ten = new List<string>();

        private void btnADD_Click(object sender, EventArgs e)
        {
            lstName.Items.Add(txtName.Text);
            txtName.Text = "";
            txtName.Focus();

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (lstName.SelectedIndex < 0)
                lstName.Items[lstName.SelectedIndex] = txtName.Text;
            MessageBox.Show("Hãy chọn tên trong danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            return;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            lstName.Items.Add("Trần Văn A");
            lstName.Items.Add("Trần Văn B");
            lstName.Items.Add("Trần Văn C");
            lstName.Items.Add("Trần Văn D");
            lstName.Items.Add("Trần Văn E");
            lstName.Items.Add("Trần Văn F");
            lstName.Items.Add("Trần Văn G");
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            {
                return;
            }
            txtName.Text = lstName.SelectedIndex.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ten.Add(txtName.Text);
            ////
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string x in ten)

                lstName.Items.Add(x);
            // Thêm ghi chú
        }
    }
}
