using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrazyElephant.Client.Models;

namespace CrazyElephant.Client.Services
{
    public interface IDataService
    {
        List<Dish> GetAllDishes();
    }
}
