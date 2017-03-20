using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceCollector
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für RunningAppsQueryService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Wenn der Aufruf dieses Webdiensts aus einem Skript zulässig sein soll, heben Sie mithilfe von ASP.NET AJAX die Kommentarmarkierung für die folgende Zeile auf. 
    // [System.Web.Script.Services.ScriptService]
    public class RunningAppsQueryService : System.Web.Services.WebService
    {
        static List<string> appList;

        public List<string> GetInstance()
        {
            if (appList == null)
            {
                appList = new List<string>();
                string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
                {
                    foreach (string subkey_name in key.GetSubKeyNames())
                    {
                        using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                        {
                            if (subkey.GetValue("DisplayName") != null)
                            {
                                appList.Add(subkey.GetValue("DisplayName").ToString());
                            }

                        }
                    }
                }
            }
            return appList;
        }


        [WebMethod]
        public List<string> QueryApps()
        {
            return GetInstance();
        }
    }
}
