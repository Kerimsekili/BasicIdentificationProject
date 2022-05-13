using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to Database : " + customer.FirstName);
        }
    }
}
