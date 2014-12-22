using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace Common
{
    public class BooleanFormatter : IFormatProvider, ICustomFormatter
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

    public class DepartmentFormatter : IFormatProvider, ICustomFormatter
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

    public class PositionFormatter : IFormatProvider, ICustomFormatter
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

    public class FamilyTypeFormatter : IFormatProvider, ICustomFormatter
    {
        DataTable dataSource;
        string displayMember, valueMember;

        public FamilyTypeFormatter(DataTable dataSource, string displayMember, string valueMember)
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

    public class AddressTypeFormatter : IFormatProvider, ICustomFormatter
    {
        DataTable dataSource;
        string displayMember, valueMember;

        public AddressTypeFormatter(DataTable dataSource, string displayMember, string valueMember)
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

    public class PhoneTypeFormatter : IFormatProvider, ICustomFormatter
    {
        DataTable dataSource;
        string displayMember, valueMember;

        public PhoneTypeFormatter(DataTable dataSource, string displayMember, string valueMember)
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

    public class PaperTypeFormatter : IFormatProvider, ICustomFormatter
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

    public class SalaryTypeFormatter : IFormatProvider, ICustomFormatter
    {
        DataTable dataSource;
        string displayMember, valueMember;

        public SalaryTypeFormatter(DataTable dataSource, string displayMember, string valueMember)
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

    public class AllowanceTypeFormatter : IFormatProvider, ICustomFormatter
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

    public class ShiftGroupFormatter : IFormatProvider, ICustomFormatter
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

    public class DataTypeFormatter : IFormatProvider, ICustomFormatter
    {
        List<DataType> dataSource;

        public DataTypeFormatter(List<DataType> dataSource)
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
                if (formatValue == dataSource[i].ID) return dataSource[i].Name;
            }
            return string.Empty;
        }
    }

    public class ItemTypeFormatter : IFormatProvider, ICustomFormatter
    {
        List<ItemType> dataSource;

        public ItemTypeFormatter(List<ItemType> dataSource)
        {
            this.dataSource = dataSource;
        }

        public object GetFormat(Type type)
        {
            return this;
        }

        public string Format(string formatString, object arg, IFormatProvider formatProvider)
        {
            byte formatValue = Convert.ToByte(arg);

            for (int i = 0; i < dataSource.Count; i++)
            {
                if (formatValue == dataSource[i].ID) return dataSource[i].Name;
            }
            return string.Empty;
        }
    }
}
