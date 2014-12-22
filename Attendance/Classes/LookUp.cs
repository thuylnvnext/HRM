using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Attendance.Classes
{
    public class AttendanceItemType
    {
        private byte iD;
        private string name;

        public AttendanceItemType(byte iD, string name)
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

    public class AttendanceItemTypes : ArrayList
    {
        public AttendanceItemTypes()
            : base()
        {
        }
        public new AttendanceItemType this[int index]
        {
            get
            {
                return (AttendanceItemType)base[index];
            }
        }
    }
}
