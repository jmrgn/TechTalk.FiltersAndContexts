using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechTalk.FiltersAndContexts
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
          
        }
    }
}
