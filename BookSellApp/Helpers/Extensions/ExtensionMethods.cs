using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BookSellApp.Helpers.Extensions
{
    public static class ExtensionMethods
    {
        public static string ListToString(this List<string> errors)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in errors)
            {
                sb.Append(errors);
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}