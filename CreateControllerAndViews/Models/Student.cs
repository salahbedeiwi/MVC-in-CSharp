using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateControllerAndViews.Models
{
    public class Student
    {
        private int _id;
        public int ID { get { return _id; } set { _id = value; } }
        private string _name;
        public string NAME { get { return _name; } set { _name = value; } }
    }
}