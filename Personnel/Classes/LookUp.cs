using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Personnel.Classes
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

    class Sexes : ArrayList
    {
        public Sexes() : base()
        {
        }
        public new Sex this[int index]
        {
            get
            {
                return (Sex)base[index];
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

    class SearchResults : ArrayList
    {
        public SearchResults()
            : base()
        {
        }
        public new SearchResult this[int index]
        {
            get
            {
                return (SearchResult)base[index];
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

    class Alignments : ArrayList
    {
        public Alignments()
            : base()
        {
        }
        public new Alignment this[int index]
        {
            get
            {
                return (Alignment)base[index];
            }
        }
    }
}
