using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Collections;

namespace Database
{
    public abstract class ItemR : DataRow
    {
        public ItemR(DataRowBuilder rb)
            : base(rb)
        {
        }
        public abstract string ID
        {
            get;
            set;
        }
        public abstract string ItemGroupID
        {
            get;
            set;
        }
        public abstract string Name
        {
            get;
            set;
        }
        public abstract string DataType
        {
            get;
            set;
        }
        public abstract string Value
        {
            get;
            set;
        }
        public abstract bool IsValueNull();
        public abstract int Rounding
        {
            get;
            set;
        }
    }
    public abstract class ItemT : DataTable, IEnumerable
    {
        public ItemT()
            : base("ItemT")
        {
        }
        public ItemT(string tableName)
            : base(tableName)
        {
        }
        public new object Clone()
        {
            object newInstance = Activator.CreateInstance(this.GetType());
            PropertyInfo[] properties = newInstance.GetType().GetProperties();
            int i = 0;

            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                if (properties[i].Name != "PrimaryKey" && properties[i].CanWrite) properties[i].SetValue(newInstance, pi.GetValue(this, null), null);
                i++;
            }

            return newInstance;
        }
        public abstract ItemR this[int index]
        {
            get;
        }
        public abstract string ItemGroupID
        {
            get;
        }
        public abstract IEnumerator GetEnumerator();
        public abstract void GetContent();
        public abstract int GetListIsNull();
        public abstract int GetListByItemGroupID(string itemGroupIDList);
        public abstract bool Insert();
        public abstract bool Update();
        public abstract bool Delete();
        public abstract void AddItemRow(ItemR r);
        public abstract DataColumnCollection GetColumns();
        public abstract string GetNewID();
    }
    public abstract class ItemGroupR : DataRow
    {
        public ItemGroupR(DataRowBuilder rb)
            : base(rb)
        {
        }
        public abstract string ParentID
        {
            get;
            set;
        }
        public abstract string ID
        {
            get;
            set;
        }
        public abstract string Name
        {
            get;
            set;
        }
        public abstract int SortOrder
        {
            get;
            set;
        }
        public abstract bool IsParentIDNull();
        public abstract bool IsSortOrderNull();
    }
    public abstract class ItemGroupT : DataTable, IEnumerable
    {
        public ItemGroupT()
            : base("ItemGroup")
        {
        }
        public ItemGroupT(string tableName)
            : base(tableName)
        {
        }
        public new object Clone()
        {
            object newInstance = Activator.CreateInstance(this.GetType());
            PropertyInfo[] properties = newInstance.GetType().GetProperties();
            int i = 0;

            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                if (properties[i].Name != "PrimaryKey" && properties[i].CanWrite) properties[i].SetValue(newInstance, pi.GetValue(this, null), null);
                i++;
            }

            return newInstance;
        }
        public abstract ItemGroupR this[int index]
        {
            get;
        }
        public abstract IEnumerator GetEnumerator();
        public abstract ItemGroupR FindByID(string iD);
        public abstract void GetContent();
        public abstract bool Insert();
        public abstract bool Update();
        public abstract bool Delete();
        public abstract void AddItemGroupRow(ItemGroupR r);
        public abstract bool Delete(string iD);
    }
    public abstract class RegisterItemR : DataRow
    {
        public RegisterItemR(DataRowBuilder rb)
            : base(rb)
        {
        }
    }
    public abstract class RegisterItemT : DataTable, IEnumerable
    {
        public RegisterItemT()
            : base("RegisterItem")
        {
        }
        public RegisterItemT(string tableName)
            : base(tableName)
        {
        }
        public new object Clone()
        {
            object newInstance = Activator.CreateInstance(this.GetType());
            PropertyInfo[] properties = newInstance.GetType().GetProperties();
            int i = 0;

            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                if (properties[i].Name != "PrimaryKey" && properties[i].CanWrite) properties[i].SetValue(newInstance, pi.GetValue(this, null), null);
                i++;
            }

            return newInstance;
        }
        public abstract RegisterItemR this[int index]
        {
            get;
        }
        public abstract DataColumnCollection GetColumns();
        public abstract IEnumerator GetEnumerator();
        public abstract int GetListByEmployeeID(string employeeIDList, int count);
        public abstract bool Insert();
        public abstract bool Update();
        public abstract bool Delete();
        public abstract void AddRegisterItemRow(RegisterItemR r);
    }
    public abstract class StatisticItemR : DataRow
    {
        public StatisticItemR(DataRowBuilder rb)
            : base(rb)
        {
        }
        public abstract string ParentID
        {
            get;
            set;
        }
        public abstract bool IsParentIDNull();
        public abstract string ID
        {
            get;
            set;
        }
        public abstract string Name
        {
            get;
            set;
        }
        public abstract string Value
        {
            get;
            set;
        }
        public abstract bool IsValueNull();
        public abstract string ComputedValue
        {
            get;
            set;
        }
    }
    public abstract class StatisticItemT : DataTable, IEnumerable
    {
        public StatisticItemT()
            : base("StatisticItemT")
        {
        }
        public StatisticItemT(string tableName)
            : base(tableName)
        {
        }
        public new object Clone()
        {
            object newInstance = Activator.CreateInstance(this.GetType());
            PropertyInfo[] properties = newInstance.GetType().GetProperties();
            int i = 0;

            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                if (properties[i].Name != "PrimaryKey" && properties[i].CanWrite) properties[i].SetValue(newInstance, pi.GetValue(this, null), null);
                i++;
            }

            return newInstance;
        }
        public abstract StatisticItemR this[int index]
        {
            get;
        }
        public abstract void GetContent();
        public abstract IEnumerator GetEnumerator();
        public abstract StatisticItemR FindByID(string iD);
        public abstract bool Insert();
        public abstract bool Update();
        public abstract bool Delete();
        public abstract StatisticItemR AddStatisticItemRow(string parentID, string iD, string name, string value, string computedValue);
        public abstract string GetNewID();
        public abstract int GetListByValue();
    }
}
