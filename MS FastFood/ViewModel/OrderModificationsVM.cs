using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_FastFood.ViewModel
{
    using Model;
    using Model.Encje;
    using BaseClasses;
    using System.Windows.Input;
    using System.Collections.ObjectModel;
    using View;
    using ViewModel;
    using System.Windows;

    class OrderModificationsVM : ViewModelBase
    {

        private Model model = null;
        int idCheck = -1;
        private bool dodawanieDostepne = true;
        private bool edycjaDostepna = true;

        public OrderModificationsVM(Model model)
        {
            this.model = model;
            Order_Items = model.Order_Items;
        }

        public ObservableCollection<order_items> Order_Items { get; set; }

        public bool DodawanieDostepne
        {
            get { return dodawanieDostepne; }
            set
            {
                dodawanieDostepne = value;
                onPropertyChanged(nameof(DodawanieDostepne));
            }
        }

        public int IdCheck
        {
            get { return idCheck; }
            set
            {
                idCheck = value;
                onPropertyChanged(nameof(IdCheck));
            }
        }


        private ICommand add = null;

        public ICommand Add
        {

            get
            {
                MessageBox.Show(Order_control.Ti);
                if (add == null)
                    add = new RelayCommand(
                        arg =>
                        {
                            if (Order_control.Ti == "Burgers")
                            {

                                model.AddBurgerDoOrderItems(Order_control.currentBurger);
                                }else if (Order_control.Ti == "Drinks")
                                {
                                model.AddDrinkToOrderItems(Order_control.currentDrink);
                            }
                            else if (Order_control.Ti == "Sets")
                                {
                                model.AddSetToOrderItems(Order_control.currentSet);
                            }
                        }
                        ,
                        arg => (true) 
                        );


                return add;
            }

        }

        public order_items CurrentItem { get; set; }

        //public string 
        //{
        //    get { return imie; }
        //    set
        //    {
        //        imie = value;
        //        onPropertyChanged(nameof(Imie));
        //    }
        //}
    }
}
