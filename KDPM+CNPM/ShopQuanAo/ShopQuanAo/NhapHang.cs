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
    public partial class NhapHang : Form
    {
        DataClasses1DataContext ql = new DataClasses1DataContext();
        public NhapHang()
        {
            InitializeComponent();
        }

        private void nHAPHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHAPHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NHAPHANG' table. You can move, or remove it, as needed.
            this.nHAPHANGTableAdapter.Fill(this.dataSet1.NHAPHANG);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void nHAPHANGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string masp = nHAPHANGDataGridView.CurrentRow.Cells[1].ToString();
            NHAPHANG sp = ql.NHAPHANGs.Where(t => t.MASP == masp).FirstOrDefault();
            SANPHAM spd = ql.SANPHAMs.Where(t => t.MASP == masp).FirstOrDefault();
            spd.SOLUONG = spd.SOLUONG + sp.SOLUONG;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
