using Task2.Domain;
using Task2.Domain.Methods;

Dog firstDog = new Dog() { Name = "Sharko", Type = "Golden Retriever", Age = 4, FavoriteFood = "Fish" };
Dog secondDog = new Dog() { Name = "Mittens", Type = "Labrador", Age = 2, FavoriteFood = "Chicken" };

Cat firstCat = new Cat() { Name = "Simba", Type = "Persian", Age = 1, IsLazy = true, LivesLeft = 8 };
Cat secondCat = new Cat() { Name = "Waffle", Type = "Bombay", Age = 3, IsLazy = false, LivesLeft = 4 };

Fish firstFish = new Fish() { Name = "Golder", Type = "Shark", Age = 5, Color = "White", Size = 20 };
Fish secondFish = new Fish() { Name = "Blackfish", Type = "Tuna", Age = 2, Color = "Black", Size = 15 };


PetStore<Dog> dogStore = new PetStore<Dog>();
dogStore.Add(firstDog);
dogStore.Add(secondDog);

PetStore<Cat> catStore = new PetStore<Cat>();
catStore.Add(firstCat);
catStore.Add(secondCat);

PetStore<Fish> fishStore = new PetStore<Fish>();
fishStore.Add(firstFish);
fishStore.Add(secondFish);

Console.WriteLine("Before buying");
dogStore.PrintsPets();
catStore.PrintsPets();
fishStore.PrintsPets();

dogStore.BuyPet("Sharko");
catStore.BuyPet("Simba");

Console.WriteLine("After buying");
dogStore.PrintsPets();
catStore.PrintsPets();
fishStore.PrintsPets();






