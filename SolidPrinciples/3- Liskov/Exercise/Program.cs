// See https://aka.ms/new-console-template for more information
using Exercise;


/*
    Liskov's Substitution principle
    Bir sınıf, miras aldığı sınıfın özelliklerini aynen kullanmak zorundadır. 
    Bir sınıf, bir başkasına miras veriyorsa bu sınıflar birbirleri yerine kullanılabilmelidirler.
   
 */



var rent = Rents.Validate(DateTime.Now, 15, 2);
var rent1 = Rents.Validate(DateTime.Now, 15,model:"Supra");
var rent2 = Rents.Validate(DateTime.Now, 15);

rent.Validation();
rent1.Validation();
rent2.Validation(); 