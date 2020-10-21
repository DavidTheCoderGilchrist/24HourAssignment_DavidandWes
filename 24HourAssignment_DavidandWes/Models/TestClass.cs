using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _24HourAssignment_DavidandWes.Models
{
    public class TestClass
    {
        public static ApplicationDbContext Test()
        {
            return new ApplicationDbContext();
        }

    }
}