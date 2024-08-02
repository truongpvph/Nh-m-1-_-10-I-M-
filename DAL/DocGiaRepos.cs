using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DocGiaRepos
    {
        MyContext context = new MyContext();
        public DocGiaRepos()
        {
            context = new MyContext();
        }
        public List<DocGium> GetAll()
        {
            return context.DocGia.ToList();
        }
        public List<DocGium> GetDG(string ten)
        {
            return context.DocGia.Where(p => p.TenDocGia.Contains(ten)).ToList();
        }
        public bool AddDG(DocGium dg)
        {
            try
            {
                context.DocGia.Add(dg);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateDG(DocGium dg)
        {
            try
            {
                var updateItem = context.DocGia.Find(dg.MaDocGia);
                updateItem.MaDocGia = dg.MaDocGia;
                updateItem.TenDocGia = dg.TenDocGia;
                updateItem.Sdt = dg.Sdt;
                context.DocGia.Update(updateItem);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
