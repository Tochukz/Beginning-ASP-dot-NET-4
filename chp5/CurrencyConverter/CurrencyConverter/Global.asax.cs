using System.Web;

namespace CurrencyConverter
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
        }
    }
}

/**
 * Some of the most common Application Events:
 * Application_Start() -> Only for first request.
 * Application_End()
 * Application_BeginRequest()
 * Application_EndRequest()
 * Session_Start()
 * Session_End()
 * Application_Error()
 */ 