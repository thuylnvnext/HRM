using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Function
    {
        private string iD;
        private string name;

        public Function(string iD, string name)
        {
            this.iD = iD;
            this.name = name;
        }

        public string ID
        {
            get
            {
                return iD;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
