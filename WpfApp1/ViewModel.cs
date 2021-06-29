using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ViewModel
    {
        private int ID;
        public int id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        private string Name;
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        private string Tel;
        public string tel
        {
            get
            {
                return Tel;
            }
            set
            {
                Tel = value;
            }
        }
        private string Address;
        public string address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
    }
}
