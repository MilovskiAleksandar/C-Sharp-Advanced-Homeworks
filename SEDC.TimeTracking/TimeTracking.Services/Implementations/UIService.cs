using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Models;
using TimeTracking.Services.Interfaces;

namespace TimeTracking.Services.Implementations
{
    public class UIService : IUIService
    {
        //1.we need one DataForRegister to provide data
        //2.we need Data
        public Users DataForRegister()
        {
            //TO ASK FOR DATA 
            string firstName = EnterData("first name");
            string lastName = EnterData("last name");
            string userName = EnterData("username");
            string password = EnterData("password");
            string age = EnterData("age");
            bool parsedAge = int.TryParse(age, out int ageInput);

            //Now create a user with this data

            Users user = new Users()
            {
                FirstName = firstName,
                LastName = lastName,
                UserName = userName,
                Password = password,
                Age = ageInput

            };
            return user;
        }

        private string EnterData(string data)
        {
            Console.WriteLine($"Enter {data}");
            string inputData = Console.ReadLine();
            if(string.IsNullOrEmpty(inputData))
            {
                throw new Exception($"You must enter {data}");
            }
            return inputData;
        }

        public string SecondaryMenu(Users user)
        {
            List<string> menu = new List<string>();
            menu.Add("Tracking activities");
            menu.Add("User Statistics");
            menu.Add("Account Management");
            //menu.Add("Change password");
            //menu.Add("Change first name");
            //menu.Add("Change last name");
            menu.Add("Deactivate account");
            menu.Add("Log out");

            int numberInput = 0;
            while (true)
            {
                Console.WriteLine("Choose an option");
                for(int i = 0; i < menu.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menu[i]}");
                }

                string input = Console.ReadLine();
                bool parsedInput = int.TryParse(input, out numberInput);
                if(!parsedInput)
                {
                    Console.WriteLine("You must enter a number");
                }

                if(numberInput < 1 || numberInput > menu.Count)
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }
                break;
            }
            return menu[numberInput - 1];

        }

        
    }
}
