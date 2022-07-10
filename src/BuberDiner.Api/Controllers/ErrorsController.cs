using Microsoft.AspNetCore.Mvc;

namespace BuberDiner.Api.Controllers
{
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorsController : Controller
    {
        [Route("/error")]
        public IActionResult Index()
        {
            //Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
            //var (statusCode, message) = exception switch
            //{
            //    DuplicateEmailException => (StatusCodes.Status400BadRequest, exception.Message),
            //    _ => (StatusCodes.Status500InternalServerError, "An unexpected error ocurred")
            //};

            return Problem();
        }
    }
}
