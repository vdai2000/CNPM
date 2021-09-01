using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo
{
    public partial class BangChamCong : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=VANDAI\SQLEXPRESS;Initial Catalog=QUANLYSHOPQUANAO;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        Bitmap bitmap1, bitmap2;
        public BangChamCong()
        {
            InitializeComponent();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            bool compare = ImageCompareString(bitmap1, bitmap2);
            if (compare == true)
            {
                MessageBox.Show("Chấm Công Thành Công","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

                this.Hide();
            }
            else
            {
                MessageBox.Show("Chấm Công Thất Bại !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ImageCompareString(Bitmap bit1, Bitmap bit2)
        {
            MemoryStream ms = new MemoryStream();
            bit1.Save(ms, ImageFormat.Bmp);
            string VT1 = Convert.ToBase64String(ms.ToArray());
            ms.Position = 0;
            bit2.Save(ms, ImageFormat.Bmp);
            string VT2 = Convert.ToBase64String(ms.ToArray());
            if (VT1.Equals(VT2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            if (openflg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openflg.FileName;
                bitmap1 = new Bitmap(openflg.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            if (openflg.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openflg.FileName;
                bitmap2 = new Bitmap(openflg.FileName);
            }
        }
    }
}
