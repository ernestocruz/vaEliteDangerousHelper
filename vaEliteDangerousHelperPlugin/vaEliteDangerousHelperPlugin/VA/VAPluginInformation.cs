using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vaEliteDangerousHelperPlugin.Models;

namespace vaEliteDangerousHelperPlugin.VA
{
    public class VAPluginInformation
    {
        private PluginInfo _pluginInfo;
        public VAPluginInformation()
        {
            _pluginInfo = new PluginInfo();
            _pluginInfo.PluginGuid = new Guid("27F581E0-0D77-42AF-9BE9-28BD23691BE8");
            _pluginInfo.DisplayName = "Elite Dangerous Helper";
            _pluginInfo.PluginDescription = "Elite Dangerous Plugin for Logging Commands";
        }

        public Guid PluginGuid
        {get{return _pluginInfo.PluginGuid;}}

        public string DisplayName
        { get { return _pluginInfo.DisplayName; } }

        public string PluginDescription
        { get { return _pluginInfo.PluginDescription; } }
    }
}
