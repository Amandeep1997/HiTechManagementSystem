using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal.DAL;
namespace ClassLibraryFinal.BUI
{
   public class User
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public Boolean UserAuthentication(int UserId, string Password)
        {
            return UserDB.Authentication(UserId, Password);
        }
        public bool AddUser(User user)
        {
            return UserDB.AddUser(user);
        }
        public User SearchUser(int UserId)
        {
            return UserDB.searchUSerRecord(UserId);
        }
        public List<User> ListUser()
        {
            return UserDB.ListUserRecord();
        }
        public void UpdateUser(User user)
        {

            UserDB.UpdateUser(user);
        }
        public void DeleteUser(User user)
        {
            UserDB.DeleteUser(user);
        }
    }
}
