using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreWithAngular.Models;
namespace ASPCoreWithAngular.Interfaces
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetAllCustomer();
        int AddCustomer(Customer customer);
        int UpdateCustomer(Customer customer);
        Customer GetCustomerData(int id);
        int DeleteCustomer(int id);
        List<UnitofMeasure> GetUom();
    }
}
