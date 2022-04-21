using System;
using System.Collections.Generic;
using System.IO;
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
        /// <summary>
        /// Clears VA Log in main screen
        /// </summary>
        public void ClearLog()
        {
            _vaProxy.ClearLog();
        }

        /// <summary>
        /// Sets main screen opacity level from 0 to 100
        /// </summary>
        /// <param name="value"></param>
        public void SetOpacity(int value)
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Invalid opacity value. Please pass value between 0 and 100","value");

            _vaProxy.SetOpacity(value);
        }

        public Version ProxyVersion
        {
            get {
                return _vaProxy.ProxyVersion;
            }
        }

        public Version VoiceAttackVersion
        {
            get
            {
                return _vaProxy.VAVersion;
            }
        }

        public string PluginPath
        {
            get
            {
                return _vaProxy.PluginPath;
            }
        }

        /// <summary>
        /// Returns whether or not the user has clicked the Stop All Commands in VA UI.
        /// </summary>
        /// <returns></returns>
        public bool Stopped
        {
            get
            {
                return _vaProxy.Stopped;
            }
        }

        /// <summary>
        /// Returns Voice Attack Installation Directory
        /// </summary>
        /// <returns></returns>
        public string InstallDir
        {
            get
            {
                return _vaProxy.InstallDir;
            }
        }

        /// <summary>
        /// Returns the path to the VA sounds directory.
        /// </summary>
        /// <returns></returns>
        public string SoundsDirectory
        {
            get
            {
                return _vaProxy.SoundsDir;
            }
        }

        /// <summary>
        /// Returns path of VA Apps directory.
        /// </summary>
        /// <returns></returns>
        public string AppsDirectory
        {
            get
            {
                return _vaProxy.AppsDir;
            }
        }

        /// <summary>
        /// Voice Attack shared assemblies directory
        /// </summary>
        /// <returns></returns>
        public string AssembliesDirectory
        {
            get
            {
                return _vaProxy.AssembliesDir;
            }
        }

        /// <summary>
        /// Will reset the flag used by Stopped
        /// </summary>
        public void ResetStopFlag()
        {
            _vaProxy.ResetStopFalg();
        }

        /// <summary>
        /// Returns whether the current version of VA is a released version.
        /// </summary>
        /// <returns></returns>
        public bool IsReleaseVersion
        {
            get
            {
                return _vaProxy.IsRelease;
            }
        }

        /// <summary>
        /// Returns whether current version of VA is Trial Version or not
        /// </summary>
        /// <returns></returns>
        public bool IsTrialVersion
        {
            get
            {
                return _vaProxy.IsTrial;
            }
        }

        public bool PluginsEnabled
        {
            get
            {
                return _vaProxy.PluginsEnabled;
            }
        }

        public bool NestedTokensEnabled
        {
            get
            {
                return _vaProxy.NestedTokensEnabled;
            }
        }

        public bool AutoProfileSwitchingEnabled
        {
            get
            {
                return _vaProxy.AutoProfileSwitchingEnabled;
            }
        }

        public IntPtr MainWindowHandle
        {
            get
            {
                return _vaProxy.MainWindowHandle;
            }
        }

        public void Close()
        {
            _vaProxy.Close();
        }

        #region "Utility"
        public string[] ExtractPhrases(string phrases, bool trimSpaces = false, bool lowercase = false)
        {
            return _vaProxy.Utility.ExtractPhrases(phrases, trimSpaces, lowercase);
        }

        /// <summary>
        /// Extract value from any available token
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ParseTokens(string value)
        {
            return _vaProxy.Utility.ParseTokens(value);
        }

        public MemoryStream CapturedAudio(int type)
        {
            return _vaProxy.Utility.CapturedAudio(type);
        }
        #endregion

    }
}
