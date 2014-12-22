using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Reflection;

namespace Database
{
    public interface IItemRow
    {
        string ID
        {
            get;
        }
        string ItemGroupID
        {
            get;
        }
        string Name
        {
            get;
        }
        string DataType
        {
            get;
        }
        string Value
        {
            get;
        }
        int Rounding
        {
            get;
        }
        bool IsValueNull();
    }
    public interface IItemTable
    {
        DataColumnCollection GetColumns();        
        bool Insert();
        bool Update();
        bool Delete();
        int GetListByItemGroupID(string itemGroupIDList);
        string GetNewID();
    }
    public interface IItemGroupRow
    {
        string ID
        {
            get;
            set;
        }
        string ParentID
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
        int SortOrder
        {
            get;
            set;
        }
        bool IsParentIDNull();
        bool IsSortOrderNull();
    }
    public interface IItemGroupTable
    {
        void GetContent();
        bool Insert();
        bool Update();
        bool Delete(string iD);
        IEnumerator GetEnumerator();
        IItemGroupRow FindByID(string iD);
        IItemGroupRow AddItemGroupRow(string parentID, string iD, string name, int sortOrder);
    }
    public interface IListTable
    {
        void GetContent();
        DataColumnCollection GetColumns();
        bool Insert();
        bool Update();
        bool Delete(string iD);
    }
}
