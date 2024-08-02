using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChitietBLL
    {
        //ChitietRepository repos;
        //SachRepository reposs;
        //public ChitietBLL()
        //{
        //    repos = new ChitietRepository();
        //}
        //public List<ChiTietPhieuMuon> GetChiTietPhieuMuons()
        //{
        //    return repos.GetAll();
        //}
        //public string SuaCT(ChiTietPhieuMuon ct)
        //{
        //    var ctphieumuon = repos.GetAll().Find(x => x.MaChiTiet == ct.MaChiTiet);
        //    if (ctphieumuon == null)
        //    {
        //        return "Không tìm thấy phiếu cần sửa";
        //    }
        //    if (ct.NgayMuon > ct.NgayTra)
        //    {
        //        return "Ngày trả không thể nhỏ hơn ngày mượn";
        //    }
        //    var sach = reposs.getbyms(ct.MaSach);
        //    if (sach == null)
        //    {
        //        return "Không tìm thấy sách";
        //    }
        //    if ((bool)!ctphieumuon.TrangThai && (bool)ct.TrangThai)
        //    {
        //        sach.SoLuong -= ctphieumuon.SoLuong;
        //    }
        //    if ((bool)ct.TrangThai)
        //    {
        //        sach.SoLuong += ct.SoLuong;
        //    }
        //    reposs.Update_sach(sach);
        //    if (repos.Update_obj(ct))
        //    {
        //        return "Sửa thành công";
        //    }
        //    return "Sửa thất bại";
        //}
        //public string XoaCT(string ct)
        //{
        //    var tp = repos.GetAll().Find(x => x.MaChiTiet == ct);
        //    if (repos.Remove_Obj(tp))
        //    {
        //        return "Xóa thành công";
        //    }
        //    return "Xóa thất bại";
        //}
    }
}
