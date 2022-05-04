using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Extensions
{
    public static class Extensions
    {
        public static void AddApplictionError(this HttpResponse response,string message) {
            response.Headers.Add("Application-Error",message);
            response.Headers.Add("Access-Control-Expose-Headers","Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin","*");
        }
        
    }
}