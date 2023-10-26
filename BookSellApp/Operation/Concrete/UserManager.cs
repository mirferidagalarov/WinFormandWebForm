using BookSellApp.Constants;
using BookSellApp.Helpers;
using BookSellApp.Helpers.DB;
using BookSellApp.Helpers.Extensions;
using BookSellApp.Helpers.Results.Abstract;
using BookSellApp.Helpers.Results.Concrete;
using BookSellApp.Models.Concrete;
using BookSellApp.Operation.Abstract;
using BookSellApp.Validation.Abstract;
using BookSellApp.Validation.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSellApp.Operation.Concrete
{
    /// <summary>
    /// Istifadəçi modelinə aid əməliyyatlar sinifi
    /// </summary>
    public class UserManager : IUserOperation
    {
        /// <summary>
        /// Göndərilən istifadəçi modelini əlavə edilməsi metodu
        /// </summary>
        /// <param name="model">User sinifindən bir instance göndərilməlidir</param>
        /// <returns>
        /// Geriyə İResult interfaceindən implment olunan hər hansısa bir Result sinifi qaytarıla bilər
        /// </returns>
        public IResult Add(User model)
        {
           IUserValidation userValidation=new UserValidation();
            var Validationresult=userValidation.Validate(model);
            if (!Validationresult.IsValid)
            {
                return new ErrorResult(Validationresult.Errors.ListToString());
            }

            var businessLogicResult = BusinessLogics
                .Execute
                (CheckUserExistsOrNot(model),
                CheckEmailExistsOrNot(model));

            if (!businessLogicResult.IsSuccess)
            {
                return new ErrorResult(businessLogicResult.Message);
            }
            BookAppDB.Users.Add(model);
            return new SuccessResult(UserMessage.UserAddedSuccessfly);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(BookAppDB.Users);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(BookAppDB.Users.FirstOrDefault(x => x.ID == id));
        }

        public IDataResult<int> GetNextId()
        {
            return new SuccessDataResult<int>(BookAppDB.Users.Max(x => x.ID) + 1);
        }

        public IResult Remove(User model)
        {
            BookAppDB.Users.Remove(model);
            return new SuccessResult(UserMessage.UserDeletedSuccessfly);
        }

        public IResult Update(User model)
        {
           var oldUser=BookAppDB.Users.Find(x => x.ID == model.ID);
            oldUser = model;
            return new SuccessResult(UserMessage.UserUpdatedSuccessfly);

        }


        private IResult CheckUserExistsOrNot(User user)
        {
            var exsistingUser = BookAppDB.Users.SingleOrDefault(x => x.Username.ToLower() == user.Username.ToLower());
            if (exsistingUser !=null)
            {
                return new ErrorResult(UserMessage.UserAlreadyExists);
            }

            return new SuccessResult();
        }

        private IResult CheckEmailExistsOrNot(User user)
        {
            var exsistingUser = BookAppDB.Users.SingleOrDefault(x => x.Email.ToLower() == user.Email.ToLower());
            if (exsistingUser != null)
            {
                return new ErrorResult(UserMessage.EmailAlreadyExists);
            }

            return new SuccessResult();
        }
    }
}