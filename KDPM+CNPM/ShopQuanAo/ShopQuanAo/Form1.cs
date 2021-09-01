using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=WIN-6PUB4VAQN1G\SQLEXPRESS;Initial Catalog=QUANLYSHOPQUANAO;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSanPham_Click(object sender, EventArgs e)   //Button Sản Phẩm//
        {
            SanPham fr = new SanPham();
            fr.MdiParent = this;
            NhanVien fr2 = new NhanVien();
            disconnect(fr2);
            HoaDon fr3 = new HoaDon();
            disconnect(fr3);
            NhapHang fr4 = new NhapHang();
            disconnect(fr4);
            fr.Show();
        }
        public void disconnect(Form f)
        {
            foreach (Form fr in this.MdiChildren)
            {
                if (fr.GetType() == f.GetType() && fr != f)
                {
                    fr.Dispose();
                    fr.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (ActiveMdiChild != null)
            //    ActiveMdiChild.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)   //Button Nhân Viên//
        {
            NhanVien fr = new NhanVien();
            fr.MdiParent = this;
            fr.Show();

            SanPham fr2 = new SanPham();
            disconnect(fr2);
            HoaDon fr3 = new HoaDon();
            disconnect(fr3);
            NhapHang fr4 = new NhapHang();
            disconnect(fr4);

        }

        private void btnHD_Click(object sender, EventArgs e)          //Button Hóa Đơn//
        {
            HoaDon fr = new HoaDon();
            fr.MdiParent = this;
            fr.Show();

            NhanVien fr2 = new NhanVien();
            disconnect(fr2);
            SanPham fr3 = new SanPham();
            disconnect(fr3);
            NhapHang fr4 = new NhapHang();
            disconnect(fr4);

        }

        private void btnExit_Click(object sender, EventArgs e)         //Button Thoát//
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnDX_Click(object sender, EventArgs e)           //Button Khách Hàng//
        {
            KhachHang fr = new KhachHang();
            fr.MdiParent = this;
            fr.Show();

        }

        private void btnLoad_Click(object sender, EventArgs e)          //Button Load lại dữ liệu//
        {
            KhoiTaoDuLieu fr = new KhoiTaoDuLieu();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)          //Button Nhập Hàng//
        {
            NhapHang fr = new NhapHang();
            fr.MdiParent = this;
            fr.Show();

            NhanVien fr2 = new NhanVien();
            disconnect(fr2);
            HoaDon fr3 = new HoaDon();
            disconnect(fr3);
            SanPham fr4 = new SanPham();
            disconnect(fr4);

        }

        private void button6_Click(object sender, EventArgs e)           //Button Đăng Nhập//
        {
            //if (NV(txtTenDN.Text, txtMK.Text) || QL(txtTenDN.Text, txtMK.Text))
            //{
            //    RadioButton ckb = null;
            //    foreach (RadioButton item in pnl.Controls)
            //    {
            //        if (item != null)
            //        {
            //            if (item.Checked == true)
            //            {
            //                ckb = item;
            //                if (radQL.Checked == true)
            //                {
                                MessageBox.Show("Đăng Nhập Thành Công Vào Quyền Quản Lý", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnSanPham.Enabled = true;
                                btnHD.Enabled = true;
                                btnNhanVien.Enabled = true;
                                btnNhapHang.Enabled = true;
                                btnKH.Enabled = true;
                                BangChamCong fr = new BangChamCong();
                                fr.MdiParent = this;
                                fr.Show();

            //                }
            //                if (radNV.Checked == true)
            //                {
            //                    MessageBox.Show("Đăng Nhập Thành Công Vào Quyền Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    btnSanPham.Enabled = true;
            //                    btnNhapHang.Enabled = true;
            //                    btnHD.Enabled = true;
            //                    btnNhanVien.Enabled = false;
            //                    btnKH.Enabled = true;
            //                    BangChamCong fr = new BangChamCong();
            //                    fr.MdiParent = this;
            //                    fr.Show();
            //                }
            //            }
            //            if ((radQL.Checked || radNV.Checked) == false)
            //            {
            //                MessageBox.Show("Xin vui lòng check vô Quản Lý Hoặc Nhân Viên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //        }
                    
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Sai tài khoản và mật khẩu !! Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.txtTenDN.Focus();
            //}
        }
        private bool NV(string userName, string password)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            {
                var q = from p in context.NHANVIENs
                        where p.MANV == txtTenDN.Text
                        && p.PASS == txtMK.Text
                        select p;
                if (q.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private bool QL(string userName, string password)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            {
                var q = from p in context.QUANLies
                        where p.MAQL == txtTenDN.Text
                        && p.PASS == txtMK.Text
                        select p;
                if (q.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext login = new DataClasses1DataContext();
            {
                NhanVien nv = new NhanVien();
                QUANLY kh = new QUANLY();
                if (txtTenDN.Text == "NV" || txtTenDN.Text=="nv")
                {
                    radNV.Enabled = true;
                    radNV.Checked = true;
                    radQL.Enabled = false;
                }
                else if (txtTenDN.Text == "QL" || txtTenDN.Text=="ql")
                {
                    radQL.Enabled = true;
                    radQL.Checked = true;
                    radNV.Enabled = false;
                }
                //else if (txtTenDN.Text == "")
                //{
                //    radQL.Enabled = true;
                //    radNV.Enabled = true;
                //}

            }
        }

        private void btnDX_Click_1(object sender, EventArgs e) //button Đăng Xuất
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                txtTenDN.Text = "";
                txtMK.Text = "";
                radNV.Checked = false;
                radNV.Enabled = true;
                radQL.Checked = false;
                radQL.Enabled = true;
                btnSanPham.Enabled = false;
                btnHD.Enabled = false;
                btnKH.Enabled = false;
                btnNhanVien.Enabled = false;
                btnNhapHang.Enabled = false;
            }
            else
            {
                return;
            }
        }
    }
}
