﻿using System;
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
        private ObservableCollection<drinks> Drinks = null;
        private ObservableCollection<sets> Sets = null;
        //private int indexBurger = -1;


        public DBList(Model model)
        {
            this.model = model;
            Burgers = model.burgers;
            Drinks = model.drinks;
        }

        /*public int indexcurrentburger
        {
            get => indexcurrentburger;
            set
            {
                indexcurrentburger = value;
                onPropertyChanged(nameof(indexcurrentburger));
            }
        }
        */
        public burgers CurrentBurger { get; set; }
        public drinks CurrentDrink { get; set; }
        public sets CurrentSet { get; set; }

        public ObservableCollection<burgers> burgers
        {
            get { return Burgers; }
            set
            {
                Burgers = value;
                onPropertyChanged(nameof(burgers));
            }
        }

        public ObservableCollection<drinks> drinks
        {
            get { return Drinks; }
            set
            {
                Drinks = value;
                onPropertyChanged(nameof(drinks));
            }
        }

        public ObservableCollection<burgers> sets
        {
            get { return Sets; }
            set
            {
                Sets = value;
                onPropertyChanged(nameof(sets));
            }
        }


        public void RefreshBurgers() => burgers = model.burgers;

        private ICommand Zburgers = null;
        public ICommand ZBurgers
        {
            get
            {
                if (Zburgers == null)
                    Zburgers = new RelayCommand(
                        arg =>
                        {
                            burgers = model.burgers;
                            //indexcurrentburger = -1;

                        }
                        ,
                        arg => true);
                return Zburgers;
            }
        }
    }
}