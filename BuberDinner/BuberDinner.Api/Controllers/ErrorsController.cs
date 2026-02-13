using BuberDinner.Application.Common.Errors;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

public class ErrorController : ControllerBase
{
    [Route("/error")]
    public IActionResult HandleError()
    {
        Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

        // var (statusCode, title) = exception switch
        // {
        //     IServiceException serviceException => ((int)serviceException.StatusCode, serviceException.ErrorMessage),
        //     _ => (StatusCodes.Status500InternalServerError, "An error occurred while processing your request.")
        // };

        return Problem();
    }
}