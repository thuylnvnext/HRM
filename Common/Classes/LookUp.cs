using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Common
{
    class Sex
    {
        private string iD, name;

        public Sex(string iD, string name)
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

    class ShiftStatus
    {
        private bool iD;
        private string name;

        public ShiftStatus(bool iD, string name)
        {
            this.iD = iD;
            this.name = name;
        }

        public bool ID
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

    class SearchResult
    {
        private byte iD;
        private string name;

        public SearchResult(byte iD, string name)
        {
            this.iD = iD;
            this.name = name;
        }

        public byte ID
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

    class Alignment
    {
        private byte iD;
        private string name;

        public Alignment(byte iD, string name)
        {
            this.iD = iD;
            this.name = name;
        }

        public byte ID
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

    public class BooleanType
    {
        private bool iD;
        private string name;

        public BooleanType(bool iD, string name)
        {
            this.iD = iD;
            this.name = name;
        }

        public bool ID
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

    public class ItemType
    {
        private byte iD;
        private string name;

        public ItemType(byte iD, string name)
        {
            this.iD = iD;
            this.name = name;
        }

        public byte ID
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
