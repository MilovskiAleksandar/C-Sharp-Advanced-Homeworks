using Task1.Domain.Methods;

Dog dog = new Dog("Sharko", "Black", 3, 20);
dog.PrintAnimal();
dog.Bark();

Cat cat = new Cat("Kitty", "Black and White", 1, 4);
cat.PrintAnimal();
cat.Eat("Cat food");