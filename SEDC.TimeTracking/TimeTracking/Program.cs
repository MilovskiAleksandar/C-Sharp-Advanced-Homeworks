using System.Reflection.Metadata.Ecma335;
using TimeTracking.Domain.DataBase;
using TimeTracking.Domain.Enums;
using TimeTracking.Domain.Models;
using TimeTracking.Services.Implementations;
using TimeTracking.Services.Interfaces;

IUserService<Users> user = new UserService<Users>();
IUIService uIService = new UIService();
ITrackService<Exercising> exercising = new TrackService<Exercising>();
ITrackService<Hobbies> hobbies = new TrackService<Hobbies>();
ITrackService<Readings> readings = new TrackService<Readings>();
ITrackService<Working> working = new TrackService<Working>();
//LOGIN AND REGISTER
Seed();

Users currentUser = null;

MainMenu();
void MainMenu()
{
    while (true)
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("1).Login  2).Register");
        string input = Console.ReadLine();
        bool successParsedInput = int.TryParse(input, out int userOption);
        if (!successParsedInput)
        {
            Console.WriteLine("Invalid option");
            continue;
        }

        if (userOption == 1)
        {
            //LOGIN
            Console.WriteLine("Enter username");
            string usernameInput = Console.ReadLine();

            if (string.IsNullOrEmpty(usernameInput))
            {
                throw new Exception("You must enter username");
            }

            Console.WriteLine("Enter password");
            string passwordInput = Console.ReadLine();
            if (string.IsNullOrEmpty(passwordInput))
            {
                throw new Exception("You must enter password");
            }
            currentUser = user.Login(usernameInput, passwordInput);
            currentUser.GetInfo();
            UserOptions();
            break;
        }
        else if (userOption == 2)
        {
            //REGISTER
            Users newUser = uIService.DataForRegister();

            currentUser = user.Register(newUser);
            UserOptions();
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid option! You must choose between  1).Login  2).Register");
            Console.ResetColor();
            continue;
        }

    }
}

void UserOptions()
{
    string choices = uIService.SecondaryMenu(currentUser);

    switch (choices)
    {
        case "Tracking activities":
            
                
          Console.WriteLine("1)Reading ");
          Console.WriteLine("2)Exercising ");
          Console.WriteLine("3)Working");
          Console.WriteLine("4). Back");
            string trackingInput = Console.ReadLine();
          bool success = int.TryParse(trackingInput, out int trackingOption);
          if (!success)
             {
                throw new Exception("You must enter the number from 1-3");
          
             }

          if (trackingOption == 1)
             {
                 break;
             }
          if(trackingOption == 4)
            {
                BackOption();
            }
  

            break;
        case "User Statistics":
            break;

        case "Account Management":
            while (true)
            {
                Console.WriteLine("1). Change password");
                Console.WriteLine("2). Change first name");
                Console.WriteLine("3). Change last name");
                Console.WriteLine("4). Back");

                string accountInput = Console.ReadLine();
                bool succes = int.TryParse(accountInput, out int accountOption);
                if (!succes)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must enter the number from 1-3");
                    Console.ResetColor();
                    continue;
                }

                if(accountOption < 1 || accountOption > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must enter the number from 1-3");
                    Console.ResetColor();
                    continue;
                }

                if (accountOption == 1)
                {
                    Console.WriteLine("Change password");
                    string changePassword = Console.ReadLine();
                    currentUser = user.ChangePassword(currentUser.Id, changePassword);
                    MainMenu();
                }
                else if (accountOption == 2)
                {
                    Console.WriteLine("Change first name");
                    string changeFirstName = Console.ReadLine();
                    currentUser = user.ChangeFirstName(currentUser.Id, changeFirstName);
                    MainMenu();
                }
                else if (accountOption == 3)
                {
                    Console.WriteLine("Change last name");
                    string changeLastName = Console.ReadLine();
                    currentUser = user.ChangeLastName(currentUser.Id, changeLastName);
                    MainMenu();
                }
                else if (accountOption == 4)
                {
                    BackOption();
                    break;
                }
                
            }
            break;

        case "Deactivate account":
            currentUser = user.DeactivateAccount(currentUser.Id);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Thank you for using our app. Sorry to lose you :(");
            Console.ResetColor();
            break;
        case "Log out":
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Succesfully logged out");
            Console.ResetColor();
            MainMenu();
            break;
    }
}
//No idea how to do it so this was solution :)
void BackOption()
{
    UserOptions();
}

void Seed()
{
    Exercising exercise = new Exercising()
    {
        Title = "General",
        Description = "General Exercise",
        Time = 15,
        Exercisings = new List<ExercisingTypes>()
        {
            ExercisingTypes.General,
            ExercisingTypes.Running,
            ExercisingTypes.Sport
        }
    };
    exercising.AddTrack(exercise);

    Readings reading = new Readings()
    {
        Page = 100,
        Title = "Avengers",
        Description = "Avengers book",
        Time = 120,
        Readings = new List<ReadingTypes>()
                {
                    ReadingTypes.BellesLettres,
                    ReadingTypes.Fiction,
                    ReadingTypes.ProfessionalLiterature
                }
    };
    readings.AddTrack(reading);


    Working work = new Working()
    {
        Title = "Home",
        Description = "Working from home",
        Time = 90,
        Workings = new List<WorkingTypes>()
                {
                    WorkingTypes.Home
                }
    };
    working.AddTrack(work);

    Hobbies hobbs = new Hobbies()
    {
        Title = "Football",
        Description = "Playing football",
        Time = 90,
        Hobbies = new List<HobbiesTypes>()
        {
            HobbiesTypes.Football
        }
    };
    hobbies.AddTrack(hobbs);
}

