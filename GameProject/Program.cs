using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;

Gamer gamer1 = new Gamer
{
    FirstName = "Muhammet Fatih",
    LastName = "Diker",
    DateOfBirth = new DateTime(2022, 6, 24),
    NationalityId = ""
};

GamerManager gamerManager = new GamerManager(new PersonCheckAdapter());
gamerManager.Add(gamer1);





