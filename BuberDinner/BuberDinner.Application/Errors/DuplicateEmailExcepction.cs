using System.Net;

namespace BuberDinner.Application.Common.Errors;

public class DuplicateEmailExcepction : Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

    public string ErrorMessage => "Email already exists.";
}