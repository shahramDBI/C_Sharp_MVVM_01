using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1
{
    class Model:INotifyPropertyChanged
    {
        List<ViewModel> List = new List<ViewModel>();
        public Model()
        {
            List.Add(new ViewModel { id = 1, name = "Shahram", tel = "123456789", address = "Tehran" });
            List.Add(new ViewModel { id = 2, name = "Shahrooz", tel = "123456789", address = "Shiraz" });
            List.Add(new ViewModel { id = 3, name = "Shervin", tel = "123456789", address = "Mashhad" });
            List.Add(new ViewModel { id = 4, name = "Asali", tel = "123456789", address = "Bandar" });
        }
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
                Search(ID);
                NotifyPropertyChanged("id");
            }
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string pr)
        {
            if(PropertyChanged !=null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(pr));
            }
        }

        private ViewModel VM;
        public ViewModel vm
        {
            get
            {
                return VM;
            }
            set
            {
                VM = value;
                NotifyPropertyChanged("vm");
            }
        }
        public void Search(int ID)
        {
            vm = List.Where(x => x.id == ID).Single();
        }

    }
}
