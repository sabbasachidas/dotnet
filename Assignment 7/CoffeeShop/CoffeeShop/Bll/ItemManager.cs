using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Repository;
using System.Data;

namespace CoffeeShop.Bll
{
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public bool Add(string name, int price)
        {
            return _itemRepository.Add(name, price);
        }
        public bool isExists(string name)
        {
            return _itemRepository.isExists(name);
        }
        public DataTable Display()
        {
            return _itemRepository.Display();
        }
        public DataTable Search(string name)
        {
            return _itemRepository.Search(name);
        }

        public bool Update(string name, int price, int id)
        {
            return _itemRepository.Update(name, price, id);
        }
        public bool Delete(int id)
        {
            return _itemRepository.Delete(id);
        }
    }
}