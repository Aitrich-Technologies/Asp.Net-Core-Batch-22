using System;
using Workshop4_CollExcpLinq.Models;
using Workshop4_CollExcpLinq.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop4_CollExcpLinq.Interfaces;
using Workshop4_CollExcpLinq.Exceptions;

namespace Workshop4_CollExcpLinq.Repository
{
    public sealed class UserRepository:IUserRepository
    {
        private List<User> users = new List<User>();
        private int nextID = 1;

        public List<User> getAll()
        {
            return users.Where(e => e.Role == Roles.JobSeeker).ToList();
        }
        public Boolean register(User user)
        {
            user.Id = nextID;
            user.Role= Roles.JobSeeker;
            nextID++;
            if(users.Find(e=>e.Email==user.Email)==null)
            {
                users.Add(user);
                return true;
            }
            throw new UserAlreadyExistsException(user.Email);
        }

        public User login(string email, string password)
        {
            return users.FirstOrDefault(e => e.Email == email && e.Password == password);
        }
    }
}
