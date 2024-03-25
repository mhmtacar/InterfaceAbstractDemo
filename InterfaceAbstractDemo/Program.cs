// See https://aka.ms/new-console-template for more information
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer { DateOfBirthYear = 1999, FirstName = "Mehmet", LastName = "Acar", NationalityId = "12345678910" });
