using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class SupplierBL
    {
        private static SupplierBL Instance;
        public static SupplierBL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new SupplierBL();
                }
                return Instance;
            }
        }

        //LAY RA DANH SACH
        public DataTable GetDanhSachNhaCungCap()
        {
            return SupplierDL.GetInstance.GetDanhSachNhaCungCap();
        }

        //Them NCC
        public bool ThemNCCFull(SupplierDTO nccDTO)
        {
            return SupplierDL.GetInstance.ThemNCCFull(nccDTO);
        }

        //Cap nhat 
        public bool CapNhatNCC(SupplierDTO nccDTO)
        {
            return SupplierDL.GetInstance.CapNhatNCC(nccDTO);
        }
        //XOA
        public bool XoaNCC(string MANCC)
        {
            return SupplierDL.GetInstance.NgungHopTacNCC(MANCC);
        }



        //khanh -----------------------------------
        public DataTable GetDanhSachNCC()
        {
            return SupplierDL.GetInstance.GetDanhSachNCC();
        }
    }
}
