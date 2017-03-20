using AgentComServices;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceAgent
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Wenn der Aufruf dieses Webdiensts aus einem Skript zulässig sein soll, heben Sie mithilfe von ASP.NET AJAX die Kommentarmarkierung für die folgende Zeile auf. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        

        [WebMethod]
        public void SendMessage()
        {
            ServiceCommunication com = new ServiceCommunication();
            com.Start();
            com.Submit(new CoreMessage() { Source = "WebService", Date = DateTime.Now, Data = "Test" });
        }

        [WebMethod]
        public string HelloWorld()
        {
            
            return "Hello World";
        }
    }
}
