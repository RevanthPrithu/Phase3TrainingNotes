using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp001.Models
{
    public class CustomerBO
    {
        static List<CustomerModel> customers = new List<CustomerModel> {
            new CustomerModel{Id=1,CName="Kiran",City="Hyderabad",Email="kiran@gmail.com",MobileNumber="9089344534" },
            new CustomerModel{Id=2,CName="Bobby",City="Bengauluru",Email="bobby@gmail.com",MobileNumber="807044534" },
            new CustomerModel{Id=3,CName="Chandu",City="Chennai",Email="chandu@gmail.com",MobileNumber="905344534" },
            new CustomerModel{Id=4,CName="David",City="Delhi",Email="david@gmail.com",MobileNumber="9089786734" }
        };
        public List<CustomerModel> GetAllCustomers()
        {
            return customers;
        }
        public CustomerModel GetCustomerById(int id)
        {
            return customers.Single(x => x.Id == id);
        }
        public int AddCustomer(CustomerModel c)
        {
            customers.Add(c);
            return 0;
        }
        public int EditCustomer(CustomerModel c)
        {
            int index = customers.FindIndex(x => x.Id == c.Id);
            customers[index] = c;
            return 0;
        }
        public int DeleteCustomer(CustomerModel c)
        {
            int index = customers.FindIndex(x => x.Id == c.Id);
            customers[index] = c;
            customers.RemoveAt(index);
            return 0;
        }
    }
}
