using System;
using System.Collections.Generic;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Database;

namespace Common
{
    public class Report
    {
        public static bool SetParameters(ReportDocument rd, string[] parameterName, object[] value)
        {
            try
            {
                for (int i = 0; i < parameterName.Length; i++)
                {
                    ParameterValues pv = new ParameterValues();
                    ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                    pdv.Value = value[i];
                    pv.Add(pdv);
                    rd.DataDefinition.ParameterFields[parameterName[i]].ApplyCurrentValues(pv);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool SetFormula(ReportDocument rd, string[] formula, string[] value)
        {
            try
            {
                DataDefinition dd = rd.DataDefinition;

                for (int i = 0; i < formula.Length; i++)
                {
                    dd.FormulaFields[formula[i]].Text = "'" + value[i] + "'";
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool SetTextObject(ReportDocument rd, string[] textObject, string[] value)
        {
            //try
            {
                for (int i = 0; i < textObject.Length; i++)
                {
                    ((TextObject)rd.ReportDefinition.ReportObjects[textObject[i]]).Text = value[i];
                }
            }
            //catch
            {
              //  return false;
            }
            return true;
        }
        public static bool SetTextObject(ReportDocument rd, string reportName)
        {
            TitleTable title = new TitleTable();
            int index;
            Object o;
            title.GetListByForm(reportName, Constant.language);
            foreach (TitleRow tr in title)
            {
                index = tr.Item.IndexOf('.');
                try 
                {
                    o = rd.ReportDefinition.ReportObjects[index > -1 ? tr.Item.Substring(index + 1) : tr.Item];
                    if (o is TextObject) ((TextObject)o).Text = tr.Value;
                    if (o is FieldObject) ((FormulaFieldDefinition)o).Text = tr.Value;
                }
                catch
                {
                    try
                    {
                        rd.DataDefinition.FormulaFields[(index > -1 ? tr.Item.Substring(index + 1) : tr.Item)].Text = tr.Value;
                    }
                    catch
                    {
                    }
                }
            }
            return true;
        }
    }
}
