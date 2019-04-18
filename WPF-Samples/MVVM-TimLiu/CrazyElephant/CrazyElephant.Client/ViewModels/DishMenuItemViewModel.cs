using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;
using CrazyElephant.Client.Models;

namespace CrazyElephant.Client.ViewModels
{
    class DishMenuItemViewModel : NotificationObject
    {
        public Dish Dish { get; set; }

        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.RaisePropertyChanged("IsSelected");
            }
        }
    }
}
