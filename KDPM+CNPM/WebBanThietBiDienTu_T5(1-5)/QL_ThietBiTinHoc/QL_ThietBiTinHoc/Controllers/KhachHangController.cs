using QL_ThietBiTinHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QL_ThietBiTinHoc.Controllers
{
    public class KhachHangController : Controller
    {
        //
        // GET: /KhachHang/

        ShopQADataContext db = new ShopQADataContext();

        public ActionResult DangKyVaDangNhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(FormCollection fc, KHACHHANG kh)
        {
            kh.TENKH = fc["hoten"];
            kh.GIOITINH = fc["gioitinh"];
            kh.SDT = fc["dienthoai"];
            kh.DIACHI = fc["diachi"];
            kh.USERNAME = fc["taikhoandangky"];
            kh.PASS = fc["matkhaudangky"];
            db.KHACHHANGs.InsertOnSubmit(kh);
            db.SubmitChanges();
            return RedirectToAction("DangKyVaDangNhap","KhachHang");
        }

        [HttpPost]
        public ActionResult DangNhap(FormCollection fc)
        {
            var tendn = fc["taikhoandangnhap"];
            var matkhau = fc["matkhaudangnhap"];
            if (string.IsNullOrEmpty(tendn))
            {
                ViewData["Loi"] = "Phải nhập tên đăng nhập";
            }
            else if (string.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi"] = "Phải nhập mật khẩu";
            }
            
            else
            {
                KHACHHANG kh = db.KHACHHANGs.SingleOrDefault(n => n.USERNAME == tendn && n.PASS == matkhau);
                if (kh != null)
                {
                    Session["Taikhoan"] = kh;
                    if (Session["GioHang"] != null)
                    {
                        return RedirectToAction("XemGioHang", "GioHang");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ViewData["Loi"] = "Tên đăng nhập hoặc mật khẩu không đúng";
                    return View("DangKyVaDangNhap");
                }
            }
            return View("DangKyVaDangNhap");
        }

        public ActionResult DangXuat()
        {
            Session["Taikhoan"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}
