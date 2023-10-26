using ClothesStoreManagmentSystem.Helpers;
using ClothesStoreManagmentSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagmentSystem.Operations.concrete
{
    public class UserManager : IUserOperation
    {
        public Result Add(User model)
        {

            #region Check Password or Username is Empty
            if (string.IsNullOrWhiteSpace(model.Username) || string.IsNullOrWhiteSpace(model.Password))
            {
                return new Result("Username is Password empty", false);
            }
            #endregion

            #region Check user is Already exisist or not
            var exstingUser = Database.Users.FirstOrDefault(u => u.Username.ToLower() == model.Username.ToLower());
            if (exstingUser != null)
            {
                return new Result("This is already exsisting", false);
            }
            #endregion

            #region Chech Password Lenght

            if (model.Password.Length<6)
            {
                return new Result("Password is less than six symbol", false);
            }
            #endregion

            model.Password=CryptingHelper.Encrypt(model.Password);

            Database.Users.Add(model);

            return new Result("User Added Succesfully", true);
        }

        public Result Delete(User model)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
           return Database.Users;
        }

        public int GetNextId()
        {
            return Database.Users.Max(x => x.ID) + 1;
        }

        public Result Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
