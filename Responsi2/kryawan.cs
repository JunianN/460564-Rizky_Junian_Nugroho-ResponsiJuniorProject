using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi2
{
    public class karyawan
    {
        private int _id_karyawan;
        private string _nama;

        public int id_karyawan
        {
            get { return _id_karyawan; }
            set { _id_karyawan = value; }
        }

        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }
    }

}
