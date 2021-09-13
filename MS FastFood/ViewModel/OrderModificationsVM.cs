using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public OrderModificationsVM(Model model)
        {
            this.model = model;
            Order_Items = model.Order_Items;
        }

        public ObservableCollection<order_items> Order_Items { get; set; }
        public ObservableCollection<drinks> Drinks { get; set; }
        public ObservableCollection<burgers> Burgers { get; set; }
        public ObservableCollection<sets> Sets { get; set; }
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

        public ICommand AddToOrder
        {
            get
            {
                if (add == null)
                {
                    add = new RelayCommand(
                        arg =>
                        {
                            
                            
                                MessageBox.Show(Order_control.Ti);
                                if ((Order_control.Ti == "Burgery" || Order_control.Ti == "Burgers")&& Order_control.currentBurger!=null)
                                {
                                    model.AddBurgerToOrderItems(Order_control.currentBurger);
                                }
                                else if ((Order_control.Ti == "Napoje" || Order_control.Ti == "Drinks") && Order_control.currentDrink != null)
                                {
                                    model.AddDrinkToOrderItems(Order_control.currentDrink);
                                }
                                else if ((Order_control.Ti == "Sets" || Order_control.Ti == "Zestawy") && Order_control.currentSet != null)
                                {
                                    model.AddSetToOrderItems(Order_control.currentSet);
                                }
                            


                        },
                        arg => true);
                }
                return add;
            }
        }





        public order_items CurrentItem { get; set; }
        public burgers Burger { get; set; }
        public drinks Drink { get; set; }
        public sets Set { get; set; }

    }
}

