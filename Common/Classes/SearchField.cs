using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HRMplus.Classes
{
    class SearchField
    {
        private string name, caption, formatType;
        private byte searchResult;
        private object data, and, or;

        public SearchField(string name, string caption, string formatType, object data)
        {
            this.name = name;
            this.caption = caption;
            this.formatType = formatType;
            this.data = data;
        }

        public SearchField(string name, string caption, string formatType, byte searchResult, object data)
        {
            this.name = name;
            this.caption = caption;
            this.formatType = formatType;
            this.searchResult = searchResult;
            this.data = data;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Caption
        {
            get
            {
                return caption;
            }
        }

        public string FormatType
        {
            get
            {
                return formatType;
            }
        }

        public object Data
        {
            get
            {
                return data;
            }
        }

        public object And
        {
            get
            {
                return and;
            }
            set
            {
                and = value;
            }
        }

        public object Or
        {
            get
            {
                return or;
            }
            set
            {
                or = value;
            }
        }

        public byte SearchResult
        {
            get
            {
                return searchResult;
            }
            set
            {
                searchResult = value;
            }
        }

        public bool IsAndNull()
        {
            if (And == null)
                return true;
            else
                if (And.ToString() == string.Empty || And.ToString() == "-1") return true;
            return false;
        }

        public bool IsOrNull()
        {
            if (Or == null)
                return true;
            else
                if (Or.ToString() == string.Empty || Or.ToString() == "-1") return true;
            return false;
        }
    }

    class SearchFields : ArrayList
    {
        public SearchFields() : base()
        {
        }
        public new SearchField this[int index]
        {
            get
            {
                return (SearchField)base[index];
            }
        }
    }
}
