using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using Common;

namespace Personnel.Classes
{
    class BooleanFormatter : IFormatProvider, ICustomFormatter
    {
        string trueString, falseString;

        public BooleanFormatter(string trueString, string falseString)
        {
            this.trueString = trueString;
            this.falseString = falseString;
        }

        public object GetFormat(Type type)
        {
            return this;
        }

        public string Format(string formatString, object arg, IFormatProvider formatProvider)
        {
            bool formatValue = Convert.ToBoolean(arg);

            if (formatValue)
                return trueString;
            else
                return falseString;
        }
    }

    class DepartmentFormatter : IFormatProvider, ICustomFormatter
    {
        DataTable dataSource;
        string displayMember, valueMember;

        public DepartmentFormatter(DataTable dataSource, string displayMember, string valueMember)
        {
            this.dataSource = dataSource;
            this.displayMember = displayMember;
            this.valueMember = valueMember;
        }

        public object GetFormat(Type type)
        {
            return this;
        }

        public string Format(string formatString, object arg, IFormatProvider formatProvider)
        {
            string formatValue = arg.ToString();

            foreach (DataRow dr in dataSource.Rows)
            {
                if (formatValue == dr[valueMember].ToString()) return dr[displayMember].ToString();
            }
            return string.Empty;
        }
    }

    class PositionFormatter : IFormatProvider, ICustomFormatter
    {
        DataTable dataSource;
        string displayMember, valueMember;

        public PositionFormatter(DataTable dataSource, string displayMember, string valueMember)
        {
            this.dataSource = dataSource;
            this.displayMember = displayMember;
            this.valueMember = valueMember;
        }

        public object GetFormat(Type type)
        {
            return this;
        }

        public string Format(string formatString, object arg, IFormatProvider formatProvider)
        {
            string formatValue = arg.ToString();

            foreach (DataRow dr in dataSource.Rows)
            {
                if (formatValue == dr[valueMember].ToString()) return dr[displayMember].ToString();
            }
            return string.Empty;
        }
    }

    class PaperTypeFormatter : IFormatProvider, ICustomFormatter
    {
        DataTable dataSource;
        string displayMember, valueMember;

        public PaperTypeFormatter(DataTable dataSource, string displayMember, string valueMember)
        {
            this.dataSource = dataSource;
            this.displayMember = displayMember;
            this.valueMember = valueMember;
        }

        public object GetFormat(Type type)
        {
            return this;
        }

        public string Format(string formatString, object arg, IFormatProvider formatProvider)
        {
            string formatValue = arg.ToString();

            foreach (DataRow dr in dataSource.Rows)
            {
                if (formatValue == dr[valueMember].ToString()) return dr[displayMember].ToString();
            }
            return string.Empty;
        }
    }

    class AllowanceTypeFormatter : IFormatProvider, ICustomFormatter
    {
        DataTable dataSource;
        string displayMember, valueMember;

        public AllowanceTypeFormatter(DataTable dataSource, string displayMember, string valueMember)
        {
            this.dataSource = dataSource;
            this.displayMember = displayMember;
            this.valueMember = valueMember;
        }

        public object GetFormat(Type type)
        {
            return this;
        }

        public string Format(string formatString, object arg, IFormatProvider formatProvider)
        {
            string formatValue = arg.ToString();

            foreach (DataRow dr in dataSource.Rows)
            {
                if (formatValue == dr[valueMember].ToString()) return dr[displayMember].ToString();
            }
            return string.Empty;
        }
    }

    class ShiftGroupFormatter : IFormatProvider, ICustomFormatter
    {
        DataTable dataSource;
        string displayMember, valueMember;

        public ShiftGroupFormatter(DataTable dataSource, string displayMember, string valueMember)
        {
            this.dataSource = dataSource;
            this.displayMember = displayMember;
            this.valueMember = valueMember;
        }

        public object GetFormat(Type type)
        {
            return this;
        }

        public string Format(string formatString, object arg, IFormatProvider formatProvider)
        {
            string formatValue = arg.ToString();

            foreach (DataRow dr in dataSource.Rows)
            {
                if (formatValue == dr[valueMember].ToString()) return dr[displayMember].ToString();
            }
            return string.Empty;
        }
    }

    class DataTypeFormatter : IFormatProvider, ICustomFormatter
    {
        ArrayList dataSource;

        public DataTypeFormatter(ArrayList dataSource)
        {
            this.dataSource = dataSource;
        }

        public object GetFormat(Type type)
        {
            return this;
        }

        public string Format(string formatString, object arg, IFormatProvider formatProvider)
        {
            string formatValue = arg.ToString();

            for (int i = 0; i < dataSource.Count; i++)
            {
                if (formatValue == ((DataType)dataSource[i]).ID) return ((DataType)dataSource[i]).Name;
            }
            return string.Empty;
        }
    }    
}
