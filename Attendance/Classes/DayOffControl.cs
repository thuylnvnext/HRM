using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Calendar;
using System.Drawing;

namespace Attendance.Classes
{
    public class DayOffControl : DateControl
    {
        protected override DateEditPainter CreatePainter()
        {
            return new DayOffPainter(this);
            //return base.CreatePainter();
        }
        protected override DateEditInfoArgs CreateInfoArgs()
        {
            //note that base implementation can return DXS.Drawing.DateNavigatorPrintInfoArgs
            //if (this.BoldAppointmentDates) return new DateNavigatorBoldedInfoArgs(this);

            return new DayOffInfoArgs(this);
        }
        public new void LayoutChanged()
        {
            base.LayoutChanged();
        }
    }
    class DayOffPainter : DateEditPainter
    {
        public DayOffPainter(DateControl dc) : base(dc) { }
        protected override void DrawHeader(CalendarObjectInfoArgs info)
        {
            DateEditInfoArgs args = (DateEditInfoArgs)info;
            args.ShowDecMonth = false;
            args.ShowDecYear = false;
            args.ShowIncMonth = false;
            args.ShowIncYear = false;
            base.DrawHeader(args);
        }
        protected override void DrawDayCell(CalendarObjectInfoArgs info, DayNumberCellInfo cell)
        {
            DateEditInfoArgs args = (DateEditInfoArgs)info;
            if (cell.Date.Month != args.CurrentMonth.Month) cell.Text = string.Empty;
            base.DrawDayCell(args, cell);
        }
        protected override void DrawTodayFrame(DevExpress.XtraEditors.Calendar.CalendarObjectInfoArgs info, Rectangle bounds)    
        {         
            //base.DrawTodayFrame(info, bounds); 
        } 
    }
    class DayOffInfoArgs : DateEditInfoArgs
    {
        public DayOffInfoArgs(DateControl control) : base(control) { }
        //public override CalendarHitInfo GetHitInfo(Point pt)
        //{
        //    CalendarHitInfo info = base.GetHitInfo(pt);

        //    if (info.InfoType == CalendarHitInfoType.DecMonth || info.InfoType == CalendarHitInfoType.IncMonth || info.InfoType == CalendarHitInfoType.DecYear || info.InfoType == CalendarHitInfoType.IncYear) info.InfoType = CalendarHitInfoType.Unknown;
        //    if (info.InfoType == CalendarHitInfoType.MonthNumber && info.HitDate.Month != CurrentMonth.Month) info.InfoType = CalendarHitInfoType.Unknown;
        //    return info;
        //}
    }
}
