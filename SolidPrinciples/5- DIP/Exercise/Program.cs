// See https://aka.ms/new-console-template for more information
using Exercise;

Console.WriteLine("Hello, World!");


CustomerManager cm = new CustomerManager(new SqlCustomerDal());
CustomerManager cm2 = new CustomerManager(new OracleCustomerDal());

cm.Add(new Customer { ID =1 , Name = "Deniz"});
cm.Delete(1);

cm2.Add(new Customer { ID = 2, Name = "Cansu" });
cm2.Delete(2);