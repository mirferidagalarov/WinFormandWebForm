using BookSellApp.Constants;
using BookSellApp.Helpers.Results.Abstract;
using BookSellApp.Helpers.Results.Concrete;
using BookSellApp.Models.Concrete;
using BookSellApp.Validation.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace BookSellApp.Validation.Concrete
{
    public class UserValidation : IUserValidation
    {
        private List<string> ErrorMessage = new List<string>();
        public IValidationResult Validate(User model)
        {
            #region 1.Göndərilən modelin null olub olmamağı yoxlanılır
            if (model is null)
            {
                ErrorMessage.Add(UserMessage.UserModelCannotBeNull);

            }

            #endregion

            #region 2.Modelde username-in bosh olub olmadiqi yoxlanilir

            if (string.IsNullOrWhiteSpace(model.Username))
            {
                ErrorMessage.Add(UserMessage.UsernameCannotBeNull);
            }
            #endregion

            #region 3.Modelde username 3 simvoldan ashaghi ola bilmez

            if (model.Username.Length<3)
            {
                ErrorMessage.Add(UserMessage.UsernameCannotBeLessThan3Symbols);
            }
            #endregion

            if (ErrorMessage.Any()) //data var yoxsa yox eger bir dene olsa true qayataracaq
            {
                return new ValidationResult(ErrorMessage, false);
            }

            return new ValidationResult(true);
        }
    }
}