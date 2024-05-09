using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Class
{
    public class VuKhi
    {
        public string Name { get; set; } = "Sung luc";
        public int DoSatThuong { get; set; } = 0;

        public VuKhi()
        {
        }

        public VuKhi(string name, int doSatThuong)
        {
            this.Name = name;
            this.DoSatThuong = doSatThuong;
        }

    }
}
