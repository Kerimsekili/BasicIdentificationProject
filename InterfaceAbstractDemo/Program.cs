using System;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer{DateOfBirth = new DateTime(1998,2,26),FirstName = "Yunus Emre",LastName = "Ulusan",NationalityId = "11512086116"});
        }
    }
}
