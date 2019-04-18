using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;
using CrazyElephant.Client.Models;
using CrazyElephant.Client.Services;
using Microsoft.Practices.Prism.Commands;
using System.Windows;

namespace CrazyElephant.Client.ViewModels
{
    class MainWindowViewModel : NotificationObject
    {
        public DelegateCommand PlaceOrderCommand { get; set; }
        public DelegateCommand SelectMenuItemCommand { get; set; }

        private int count;

        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                this.RaisePropertyChanged("Count");
            }
        }

        private Restaurant restaurant;

        public Restaurant Restaurant
        {
            get { return restaurant; }
            set
            {
                restaurant = value;
                this.RaisePropertyChanged("Restaurent");
            }
        }

        private List<DishMenuItemViewModel> dishMenu;

        public List<DishMenuItemViewModel> DishMenu
        {
            get { return dishMenu; }
            set
            {
                dishMenu = value;
                this.RaisePropertyChanged("DishMenu");
            }
        }

        public MainWindowViewModel()
        {
            this.LoadRestaurant();
            this.LoadDishMenu();
            this.PlaceOrderCommand = new DelegateCommand(new Action(this.PlaceOrderCommandExecute));
            this.SelectMenuItemCommand = new DelegateCommand(new Action(this.SelectMenuItemExecute));
        }

        private void LoadRestaurant()
        {
            this.Restaurant = new Restaurant();
            this.Restaurant.Name = "Crazy大象";
            this.Restaurant.Address = "北京市海淀区万泉河路紫金庄园1号楼 1层 113室（亲们：这地儿特难找！）";
            this.Restaurant.PhoneNumber = "15210365423 or 82650336";
        }

        private void LoadDishMenu()
        {
            IDataService ds = new XmlDataService();
            var dishes = ds.GetAllDishes();
            this.DishMenu = new List<DishMenuItemViewModel>();
            foreach (var dish in dishes)
            {
                DishMenuItemViewModel item = new DishMenuItemViewModel();
                item.Dish = dish;
                this.DishMenu.Add(item);
            }
        }

        private void PlaceOrderCommandExecute()
        {
            var selectedDishes = this.DishMenu.Where(i => i.IsSelected == true).Select(i => i.Dish.Name).ToList();
            IOrderService orderService = new MockOrderService();
            orderService.PlaceOrder(selectedDishes);
            MessageBox.Show("订餐成功！");
        }

        private void SelectMenuItemExecute()
        {
            this.Count = this.DishMenu.Count(i => i.IsSelected == true);
        }
    }
}
