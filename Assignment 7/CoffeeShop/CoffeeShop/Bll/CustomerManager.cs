using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CoffeeShop.Repository;

namespace CoffeeShop.Bll
{
    class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool Add(string name, string address, string contact)
        {
            return _customerRepository.Add(name, address, contact);
        }
        public bool isExists(string name)
        {
            return _customerRepository.isExists(name);
        }
        public DataTable Display()
        {
            return _customerRepository.Display();
        }
        public DataTable Search(string name)
        {
            return _customerRepository.Search(name);
        }
        public bool Update(string name, string address, string contact, int id)
        {
            return _customerRepository.Update(name, address, contact, id);
        }
        public bool Delete(int id)
        {
            return _customerRepository.Delete(id);
        }
    }
}
