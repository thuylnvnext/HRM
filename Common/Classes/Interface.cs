using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public interface IGridViewParent
    {
        void NextGridColumn();
        string GetName();
    }

    public interface IBandedGridViewParent
    {
        void NextGridBand();
    }

    public interface IShowData
    {
        void ShowData(string departmentIDList, bool check);
    }

    public interface IMdiParent
    {
        DevExpress.XtraBars.Ribbon.RibbonControl GetRibbonControl
        {
            get;
        }
    }
}
