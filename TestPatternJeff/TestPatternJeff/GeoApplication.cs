using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public class GeoApplication
    {
        private string id;
        private string name;
        private string color;

        public GeoApplication(string id, string name, string color)
        {
            this.id = id;
            this.name = name;
            this.color = color;
        }

        private GeoApplication(string id, string name) : this (id, name, null)
        {

        }

        private GeoApplication(string id) : this(id, null, null) { }
    }
}
