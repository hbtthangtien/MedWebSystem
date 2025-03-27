using Application.ExceptionCustom;
using Presentation.Response;

namespace Presentation.Middleware
{
    public class ExceptionGlobal
    {
        private readonly RequestDelegate _next;
        public ExceptionGlobal(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }catch(RegisterException ex)
            {
                context.Response.StatusCode = 400;
                List<string> errors = ex.Message.Split(';').ToList();
                await context.Response.WriteAsJsonAsync(new ApiResponse
                {
                    Status = 400,
                    errors = errors
                }) ;
            }catch(LoginException ex)
            {
                context.Response.StatusCode = 401;
                List<string> errors = ex.Message.Split(';').ToList();
                await context.Response.WriteAsJsonAsync(new ApiResponse
                {
                    Status = 401,
                    errors = errors
                });
            }
        }
    }
}
