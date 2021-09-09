using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_FastFood.ViewModel
{
    using Model;
    using Model.Encje;
    using BaseClasses;
    using System.Windows.Input;

    class DBList : ViewModelBase
    {
        private Model model = null;
        private ObservableCollection<burgers> Burgers = null;


        public DBList(Model model)
        {
            this.model = model;
            Burgers = model.Burgers;
        }

        public burgers CurrentBurger { get; set; }

        public ObservableCollection<burgers> burgers
        {
            get { return Burgers; }
            set
            {
                Burgers = value;
                onPropertyChanged(nameof(burgers));
            }
        }

        public void RefreshBurgers() => Burgers = model.Burgers;

        private ICommand Zburgers = null;
        public ICommand ZBurgers
        {
            get
            {
                if (Zburgers == null)
                    Zburgers = new RelayCommand(
                        arg =>
                        {
                            Burgers = model.Burgers;

                        }
                        ,
                        arg => true);
                return Zburgers;
            }
        }
    }
}
