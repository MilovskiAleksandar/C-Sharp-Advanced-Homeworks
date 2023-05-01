
using Task1.Domain;

DataBase<Dog> dogs = new DataBase<Dog>();

List<Dog> readingFromFile = dogs.ReadFromFile();
foreach (Dog dogsFromFile in readingFromFile)
{
    Console.WriteLine($"Name: {dogsFromFile.Name}, Age: {dogsFromFile.Age}, Color: {dogsFromFile.Color}");
}
Console.WriteLine("Enter dog name:");
string inputName = Console.ReadLine();

Console.WriteLine("Enter dog color");
string inputColor = Console.ReadLine();

Console.WriteLine("Enter dog age");
int inputAge = Convert.ToInt32(Console.ReadLine());

Dog dog = new Dog(inputName, inputColor, inputAge);
dogs.Insert(dog);