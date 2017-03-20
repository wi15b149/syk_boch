using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyFirstAspNetWebService
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für SimpleWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Wenn der Aufruf dieses Webdiensts aus einem Skript zulässig sein soll, heben Sie mithilfe von ASP.NET AJAX die Kommentarmarkierung für die folgende Zeile auf. 
    // [System.Web.Script.Services.ScriptService]
    public class SimpleWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Person DoWork(string lastname, string firstname, int age)
        {
            return new Person() { Firstname = firstname, Lastname = lastname, Age = age };
        }
    }
}
