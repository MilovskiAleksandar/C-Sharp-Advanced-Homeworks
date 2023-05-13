
using TimeTracking.Domain.DataBase;
using TimeTracking.Domain.DBInterface;
using TimeTracking.Domain.Models;
using TimeTracking.Services.Helpers;
using TimeTracking.Services.Interfaces;

namespace TimeTracking.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : Users
    {
        private IDatabase<T> _database;

        public UserService()
        {
            _database = new FileDataBase<T>();
        }

        public T ChangeFirstName(int id, string firstName)
        {
            T userDb = _database.GetById(id);
            if(userDb == null)
            {
                throw new Exception("Invalid id");
            }

            bool changeFirstName = ValidationHelper.ValidateFirstName(firstName);
            if(!changeFirstName)
            {
                throw new Exception("Invalid first name");
            }

            userDb.FirstName = firstName;
            _database.Update(userDb);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succesfully changed first name");
            Console.ResetColor();

            return userDb;
        }

        public T ChangeLastName(int id, string lastName)
        {
            T userDb = _database.GetById(id);
            if (userDb == null)
            {
                throw new Exception("Invalid id");
            }

            bool changeLastName = ValidationHelper.ValidateFirstName(lastName);
            if (!changeLastName)
            {
                throw new Exception("Invalid first name");
            }

            userDb.LastName = lastName;
            _database.Update(userDb);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succesfully changed last name");
            Console.ResetColor();

            return userDb;
        }

        public T ChangePassword(int id, string newPassword)
        {
            T userDb = _database.GetById(id);
            if(userDb == null)
            {
                throw new Exception("Invalid id");
            }

            bool changePassword = ValidationHelper.ValidatePassword(newPassword);
            if(!changePassword)
            {
                throw new Exception("Invalid password");
            }

            userDb.Password = newPassword;
            _database.Update(userDb);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succesfully changed password");
            Console.ResetColor();

            return userDb;
        }

        public T DeactivateAccount(int userId)
        {
            T userDb = _database.GetById(userId);
            userDb.Id = userId;
            _database.RemoveById(userId);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"==== Goodbye {userDb.FirstName} {userDb.LastName} ====");
            Console.WriteLine("Successfully deactivated");
            Console.ResetColor();
            return userDb;
        }

        public List<T> GetAll()
        {
            List<T> values = _database.GetAll();
            return values;
        }

        public T Login(string username, string password)
        {
            List<T> allUsers = _database.GetAll();

            T userDB = allUsers.FirstOrDefault(x => x.UserName == username && x.Password == password);
            if (userDB == null)
            {
                throw new Exception("Wrong username or password");
            }
            return userDB;
        }

        public T Register(T user)
        {
            //To validate first
            if (!ValidationHelper.ValidateFirstName(user.FirstName))
            {
                throw new Exception("Invalid first name value");
            }

            if (!ValidationHelper.ValidateLastName(user.LastName))
            {
                throw new Exception("Invalid last name value");
            }

            if(!ValidationHelper.ValidateAge(user.Age))
            {
                throw new Exception("Invalid age value");
            }

            if (!ValidationHelper.ValidateUserName(user.UserName))
            {
                throw new Exception("Invalid username value");
            }

            if (!ValidationHelper.ValidatePassword(user.Password))
            {
                throw new Exception("Invalid password value");
            }

            //2. Insert(dodadi vo baza)

            int newId = _database.Add(user);

            T newUser = _database.GetById(newId);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome to our app {newUser.FirstName} {newUser.LastName}");
            Console.ResetColor();

            return newUser;
        }
    }
}
