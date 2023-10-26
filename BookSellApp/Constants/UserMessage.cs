using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSellApp.Constants
{
    public static class UserMessage
    {
        public static readonly string UserModelCannotBeNull = "UserModelCannotBeNull";
        public static readonly string UsernameCannotBeNull = "UsernameCannotBeNull";
        public static readonly string UsernameCannotBeLessThan3Symbols = "UsernameCannotBeLessThan3Symbols";
        public static readonly string UserAddedSuccessfly = "UserAddedSuccessfly";
        public static readonly string UserAlreadyExists = "UserAlreadyExists";
        public static readonly string EmailAlreadyExists = "EmailAlreadyExists";
        public static readonly string UserDeletedSuccessfly = "UserDeletedSuccessfly";
        public static readonly string UserUpdatedSuccessfly = "UserUpdatedSuccessfly";




    }
}