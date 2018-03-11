using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Bus
    {
        DataDiagramDataContext data = new DataDiagramDataContext();
        public int check_login(string user, string pass)
        {
            int login = (from tks in data.TaiKhoans
                         where tks.username == user && tks.password == pass
                         select tks).Count();
            return login;
        }
        public object get_nhanvien()
        {
            var nhanvien = from u in data.NhanViens
                           from t in data.PhongBans
                           from v in data.PhanCongs
                           from z in data.DuAns
                           where u.MaNV == v.MaNV
                           where v.MaDA == z.MaDA
                           where u.MaPB == t.MaPB
                           select new
                           {
                               MaNV = u.MaNV,
                               HoTen = u.HoTen,
                               NS = u.NS,
                               GT = u.GT,
                               TenPB = t.TenPB,
                               TenDA = z.TenDA
                           }; ;
            return nhanvien;
        }
        public object get_nhanvien(string giatri)
        {
            var nhanvien = from u in data.NhanViens
                           from t in data.PhongBans
                           from v in data.PhanCongs
                           from z in data.DuAns
                           where u.MaNV == v.MaNV
                           where v.MaDA == z.MaDA
                           where u.MaPB == t.MaPB
                           select new
                           {
                               MaNV = u.MaNV,
                               HoTen = u.HoTen,
                               NS = u.NS,
                               GT = u.GT,
                               TenPB = t.TenPB,
                               TenDA = z.TenDA
                           } into timkiemNV
                           where timkiemNV.MaNV.Contains(giatri)
                           || timkiemNV.HoTen.Contains(giatri)
                           || timkiemNV.TenPB.Contains(giatri)
                           || timkiemNV.TenDA.Contains(giatri)
                           select timkiemNV;
            return nhanvien;
        }
        public object get_phongban()
        {
            var phongban = data.PhongBans.Select(p => p);
            return phongban;
        }
        public object get_duan()
        {
            var duan = from x in data.DuAns
                       from y in data.PhongBans
                       where x.MaPB == y.MaPB
                       select new
                       {
                           TenDA = x.TenDA,
                           DiaDiem = x.DiaDiem,
                           TenPB = y.TenPB
                       };
            return duan;
        }
    }
}
