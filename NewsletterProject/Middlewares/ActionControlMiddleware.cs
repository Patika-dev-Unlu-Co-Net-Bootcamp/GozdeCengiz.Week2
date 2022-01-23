using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace NewsletterProject.Middlewares
{
    public class ActionControlMiddleware
    {
        RequestDelegate _next;
        public ActionControlMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("Actıona gırıs yapıldı");
            await _next.Invoke(httpContext);
            Console.WriteLine("Actıondan cıkıs yapıldı");

        }
    }
}
