using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using Common;

namespace Attendance.Classes
{
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

    public class AttendanceItemTypeFormatter : IFormatProvider, ICustomFormatter
    {
        AttendanceItemTypes dataSource;

        public AttendanceItemTypeFormatter(AttendanceItemTypes dataSource)
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
