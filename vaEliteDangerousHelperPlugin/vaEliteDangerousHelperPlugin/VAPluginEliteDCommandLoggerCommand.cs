using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vaEliteDangerousHelperPlugin.Models;
using vaEliteDangerousHelperPlugin.VA;

namespace vaEliteDangerousHelperPlugin
{
    public class VAPluginEliteDCommandLoggerCommand
    {
        private static VAPluginInformation _pluginInfo = new VAPluginInformation();
        public static Guid VA_Id()
        {
            return _pluginInfo.PluginGuid;
        }
        public static string VA_DisplayName()
        {
            return _pluginInfo.DisplayName;
        }

        public static string VA_DisplayInfo()
        {
            return _pluginInfo.PluginDescription;
        }
        public static void VA_Init1(dynamic vaProxy)
        {

        }
        
        public static void VA_Invoke1(dynamic vaProxy)
        {
            vaProxyAdapter proxy = new vaProxyAdapter(vaProxy);
            proxy.WriteToLog(proxy.GetContext(),vaColor.Color.Red);
        }

        public static void VA_Exit1(dynamic vaProxy)
        { 
        
        }

        public static void VA_StopCommand()
        { 
        
        }


    }
}
