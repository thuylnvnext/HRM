using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Common
{
    public class Node : ArrayList
    {
        private string iD;
        private string name;
        private bool active;

        public Node(string iD, string name, bool active)
        {
            this.iD = iD;
            this.name = name;
            this.active = active;
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

        public bool Active
        {
            get
            {
                return active;
            }
        }
    }

    public class NodeList : ArrayList
    {
        public NodeList(): base()
        {
        }
        public new Node this[int index]
        {
            get
            {
                return (Node)base[index];
            }
        }
    }
}
