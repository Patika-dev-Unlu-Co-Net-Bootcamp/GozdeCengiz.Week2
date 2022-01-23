using Microsoft.AspNetCore.Builder;
using NewsletterProject.Middlewares;

namespace NewsletterProject.Extensions
{
    static public class ActionControlExtension
    {
        public static IApplicationBuilder UseActionControl(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<ActionControlMiddleware>();
        }
    }
}
