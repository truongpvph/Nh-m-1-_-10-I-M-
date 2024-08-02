using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DocGiaSevice
    {
        DocGiaRepos repos = new DocGiaRepos();
        public DocGiaSevice()
        {
            repos = new DocGiaRepos();
        }
        public List<DocGium> CNShow()
        {
            return repos.GetAll();
        }
        public List<DocGium> CNTim(string ten)
        {
            return repos.GetDG(ten);
        }
        public string CNThem(DocGium dg)
        {
            if (repos.AddDG(dg))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string CNSua(string ma, string ten, string sdt)
        {
            DocGium dg = new DocGium()
            {
                MaDocGia = ma,
                TenDocGia = ten,
                Sdt = sdt
            };
            if (repos.UpdateDG(dg))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
        public bool CheckSDT(string sdt)
        {
            if (sdt.Length == 10 || sdt.Trim().Length == 0) return false;
            else return true;
        }
    }
}
