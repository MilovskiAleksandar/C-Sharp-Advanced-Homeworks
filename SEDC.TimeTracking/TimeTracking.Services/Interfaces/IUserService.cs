using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Models;

namespace TimeTracking.Services.Interfaces
{
    public interface IUserService<T> where T : Users
    {
        T Register(T user);
        List<T> GetAll();

        T Login(string username, string password);

        T ChangePassword(int id, string newPassword);

        T ChangeFirstName(int id, string firstName);

        T ChangeLastName(int id, string lastName);

        T DeactivateAccount(int id);

    }
}
