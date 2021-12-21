using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using RankWebsites.API.App_Start;

namespace RankWebsites.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        void Application_Error(Object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            if (exception == null) return;

            string innerExMsg = "";
            if (exception.InnerException != null)
            {
                innerExMsg = exception.InnerException.Message;
            }

            var errormessage = exception.Message + " " + innerExMsg;
            var logger = LogManager.GetCurrentClassLogger();
            logger.Error(exception, string.Format("Error: {0} InnerEx: {1} Stack Trace: {2}", errormessage, innerExMsg, exception.StackTrace));
        }
    }


}
