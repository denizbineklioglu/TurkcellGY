// See https://aka.ms/new-console-template for more information


//Virtual - Override (Polymorphism)
using OOPExercises.Chef_Food_Presentation;

KuruFasulye krf = new KuruFasulye() { Name = "Kuru Fasulye" };
Baklava baklava = new Baklava() { Name = "Baklava" };
Chef chef = new Chef();

chef.Cook(krf);
chef.Cook(baklava);
