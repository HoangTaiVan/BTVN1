using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    internal class Information
    {
        private string MASV;
        private string HoTen;
        private string Lop;
        private string Username;
        private string Email;
        public Information(string MASV,string HoTen, string Lop,string Username,string Email)
        {
            this.MASV = MASV;
            this.HoTen = HoTen;
            this.Lop = Lop;
            this.Username = Username;
            this.Email = Email;
        }
        public void displayInformation()
        {
            Console.WriteLine("Mã sinh viên:\t " + MASV);
            Console.WriteLine("Họ và tên:\t " + HoTen);
            Console.WriteLine("Lớp đang học:\t " + Lop);
            Console.WriteLine("Github:\t " + Username);
            Console.WriteLine("Email:\t " + Email);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding= System.Text.Encoding.UTF8;
            Information information1 = new Information("10122319", "Hoàng Văn Tài", "12422TN", "https://github.com/HoangTaiVan", "hoangtai16072004@gmail.com");
            information1.displayInformation();
        }
    }
}
