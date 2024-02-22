// See https://aka.ms/new-console-template for more information

//using SampleCSharp;

//CustomerDAL dal = new CustomerDAL();
//var customers = dal.GetAll();
//foreach (var customer in customers)
//{
//    Console.WriteLine($"{customer.CustName} lives in {customer.CustCity}, {customer.CustStateProv}");
//}

using DAL;

CustomerDAL dal = new CustomerDAL();
var customers = dal.GetAll();
foreach (var customer in customers)
{
    Console.WriteLine($"{customer.CustName} lives in {customer.CustCity}, {customer.CustStateProv}");
}
