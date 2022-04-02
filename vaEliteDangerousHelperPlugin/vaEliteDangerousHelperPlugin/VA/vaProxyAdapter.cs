using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static vaEliteDangerousHelperPlugin.VA.vaColor;

namespace vaEliteDangerousHelperPlugin.VA
{
    public class vaProxyAdapter
    {
        dynamic _vaProxy;
        public vaProxyAdapter(dynamic vaProxy)
        {
            _vaProxy = vaProxy;
        }

        public string GetContext()
        {
            return _vaProxy.Context;
        }

        public Dictionary<string, object> SessionState()
        {
            return _vaProxy.SessionState;
        }

        public void SetSmallInt(string variableName,short? value)
        {
            _vaProxy.SetSmallInt(variableName,value);
        }

        public short? GetSmallInt(string variableName)
        {
            return _vaProxy.GetSmallInt(variableName);
        }

        public void SetInt(string variableName, int? value)
        {
            _vaProxy.SetInt(variableName, value);
        }

        public int? GetInt(string variableName)
        {
            return _vaProxy.GetInt(variableName);
        }

        public void SetText(string variableName,string value)
        {
            _vaProxy.SetText(variableName, value);
        }

        public string GetText(string variableName)
        {
            return _vaProxy.GetText(variableName);
        }

        public void SetDecimal(string variableName,decimal? value)
        {
            _vaProxy.SetDecimal(variableName, value);
        }

        public decimal? GetDecimal(string variableName)
        {
            return _vaProxy.GetDecimal(variableName);
        }

        public void SetBoolean(string variableName, bool? value)
        {
            _vaProxy.SetBoolean(variableName, value);
        }

        public bool? GetBoolean(string variableName)
        {
            return _vaProxy.GetBoolean(variableName);
        }

        public void SetDate(string variableName, DateTime? value)
        {
            _vaProxy.SetDate(variableName, value);
        }

        public DateTime? GetDate(string variableName)
        {
            return _vaProxy.GetDate(variableName);
        }

        public string[] ProfileName()
        {
            return _vaProxy.ProfileNames();
        }

        public Guid[] ProfileInternalIDs()
        {
            return _vaProxy.ProfileInternalIDs();
        }

        public void WriteToLog(string value, Color color)
        {
            _vaProxy.WriteToLog(value, vaColor.GetColor(color));
        }

    }
}
