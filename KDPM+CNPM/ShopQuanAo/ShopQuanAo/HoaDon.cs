using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.dataSet1.HOADON);

        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            CTHoaDon fr = new CTHoaDon();
           
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report f = new Report();
            f.Show();
        }

        private void mAKHLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
