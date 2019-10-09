using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeShop.Repository;

namespace CoffeeShop.Bll
{
    public class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();
        public bool Add(string name, int itemId, int quantity)
        {
            return _orderRepository.Add(name, itemId, quantity);
        }
        public DataTable Display()
        {
            return _orderRepository.Display();
        }
        public DataTable Search(string name)
        {
            return _orderRepository.Search(name);
        }
        public bool Update(string name, int itemId, int quantity, int id)
        {
            return _orderRepository.Update(name, itemId, quantity, id);
        }
        public bool Delete(int id)
        {
            return _orderRepository.Delete(id);
        }
    }
}
