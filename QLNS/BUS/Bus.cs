using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Globalization;

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
            if(login == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public object getData1()
        {
            var database = from u in data.NhanViens
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
                               MaPB = t.MaPB,
                               MaDA = v.MaDA
                           };

            return database;
        }
        public object Search(string text)
        {
            var database = from u in data.NhanViens
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
                               MaPB = t.MaPB,
                               MaDA = v.MaDA
                           } into timkiemNV
                           where timkiemNV.MaNV.Contains(text)
                               || timkiemNV.HoTen.Contains(text)
                               || timkiemNV.MaPB.Contains(text)
                               || timkiemNV.MaDA.Contains(text)
                           select timkiemNV;
            return database;

        }
        public object Delete(string ma)
        {
            var nv = from a in data.NhanViens
                     where a.MaNV == ma
                     select a;
            data.NhanViens.DeleteAllOnSubmit(nv);
            var nv1 = from b in data.PhanCongs
                      where b.MaNV == ma
                      select b;
            data.PhanCongs.DeleteAllOnSubmit(nv1);
            data.SubmitChanges();
            return 1;
        }
        public object Edit(string ma, string ten, string ns, string gt, string ma_pb)
        {
            NhanVien nv = data.NhanViens.Single(a => a.MaNV == ma);
            nv.MaNV = ma;
            nv.HoTen = ten;
            nv.NS = DateTime.ParseExact(ns, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (gt == "Nam")
            {
                nv.GT = false;
            }
            if (gt == "Nữ")
            {
                nv.GT = true;
            }
            nv.MaPB = ma_pb;

            data.SubmitChanges();
            return 1;
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
