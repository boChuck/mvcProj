using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using MvcApplication1.Annotations;

namespace MvcApplication1.Models
{
    public class GolfCourse
    {
        private string _name;

        public GolfCourse(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }
    }
}