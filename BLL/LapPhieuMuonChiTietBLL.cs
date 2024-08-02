using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class LapPhieuMuonChiTietBLL
    {
        LapPhieuMuonChiTietDAL db = new LapPhieuMuonChiTietDAL();

        public List<PhieuMuon> GetAllPhieuMuon()
        {
            var list = db.GetAllPhieuMuon().ToList();
            return list;
        }
        public List<Sach> GetAllSach()
        {
            var list = db.GetAllSach().ToList();
            return list;
        }
        public List<DocGium> GetAllDocGium()
        {
            var list = db.GetAllDocGium().ToList();
            return list;
        }
        public List<ChiTietPhieuMuon> GetAllChiTietPhieuMuon()
        {
            var list = db.GetAllChiTietPhieuMuon().ToList();
            return list;
        }
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            var list = db.GetAllTaiKhoan().ToList();
            return list;
        }
        public ChiTietPhieuMuon GetChiTietByMaPhieuMuon(string ma)
        {
            foreach (var i in db.GetAllChiTietPhieuMuon().ToList())
            {
                if (i.MaPhieuMuon.Equals(ma))
                {
                    return i;
                }
            }
            return null;
        }
        public DocGium GetDocGiaById(string id)
        {
            foreach (var ph in db.GetAllDocGium().ToList())
            {
                if (ph.MaDocGia.Equals(id))
                {
                    return ph;
                }
            }
            return null;
        }
        public Sach GetSachByID(string id)
        {
            foreach (var i in db.GetAllSach().ToList())
            {
                if (i.MaSach.Contains(id))
                {
                    return i;
                }
            }
            return null;
        }
        public Sach GetSachByName(string name)
        {
            foreach (var i in db.GetAllSach().ToList())
            {
                if (i.TenSach.Contains(name))
                {
                    return i;
                }
            }
            return null;
        }
        public DocGium GetDocGiumByName(string name)
        {
            foreach (var i in db.GetAllDocGium().ToList())
            {
                if (i.TenDocGia.ToLower().ToString().Contains(name.ToLower().ToString()))
                {
                    return i;
                }
            }
            return null;
        }

        public TaiKhoan GetTaiKhoanByName(string name)
        {
            foreach (var i in db.GetAllTaiKhoan().ToList())
            {
                if (i.HoTen.ToLower().ToString().Contains(name.ToLower().ToString()))
                {
                    return i;
                }
            }
            return null;
        }

        public TaiKhoan GetTaiKhoanById(string Id)
        {
            foreach (var i in db.GetAllTaiKhoan().ToList())
            {
                if (i.MaTaiKhoan.ToLower().ToString().Contains(Id.ToLower().ToString()))
                {
                    return i;
                }
            }
            return null;
        }
        public PhieuMuon GetPhieuMuonById(string id)
        {
            foreach (var i in db.GetAllPhieuMuon().ToList())
            {
                if (i.MaPhieuMuon.ToLower().ToString().Contains(id.ToLower().ToString()))
                {
                    return i;
                }
            }
            return null;
        }

        public void AddChiTiet(string maChiTiet, string maPhieuMuon, string maSach, int soLuong, double tongTien, DateOnly ngayMuon, DateOnly ngayTra, string moTa, bool trangThai)
        {
            ChiTietPhieuMuon ct = new ChiTietPhieuMuon();
            ct.MaChiTiet = maChiTiet;
            ct.MaPhieuMuon = maPhieuMuon;
            ct.MaSach = maSach;
            ct.SoLuong = soLuong;
            ct.TongTien = tongTien;
            ct.NgayTra = ngayTra;
            ct.NgayMuon = ngayMuon;
            ct.GhiChu = moTa;
            ct.TrangThai = trangThai;
            Sach s = GetSachByID(maSach);
            s.SoLuong = s.SoLuong - soLuong;
            db.AddPhieuChiTiet(ct, s);



        }
        public void ADDPhieuMuon(string maPhieuMuon, string maDocGia, string maTaiKhoan)
        {
            PhieuMuon pm = new PhieuMuon();
            pm.MaPhieuMuon = maPhieuMuon;
            pm.MaDocGia = maDocGia;
            pm.MaTaiKhoan = maTaiKhoan;
            db.AddPhieuMuon(pm);
        }
        public void UpdatePhieuMuon(string maPhieuMuon, string maDocGia, string maTaiKhoan)
        {
            PhieuMuon pm = GetPhieuMuonById(maPhieuMuon);
            pm.MaPhieuMuon = maPhieuMuon;
            pm.MaDocGia = maDocGia;
            pm.MaTaiKhoan = maTaiKhoan;

            db.UpdatePhieuMuon(pm);
        }
        public void UpdateSach(string maSach, int soLuong)
        {
            Sach s = GetSachByID(maSach);
            s.SoLuong = s.SoLuong - soLuong;
            db.UpdateSach(s);
        }
    }
}
