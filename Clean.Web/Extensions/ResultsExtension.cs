using ErrorOr;
using Microsoft.AspNetCore.Http;

namespace Clean.Web.Extensions
{
    public static class ResultsExtension
    {

        public static IResult ToErrorOrOk<TValue>(this ErrorOr<TValue> result)
        {
            IResult response = Results.Problem();
            result.SwitchFirst(
                value => { response = Results.Ok(value); },
                error => {
                    response = error.Type switch
                    {
                        ErrorType.Conflict => Results.Conflict(error),
                        ErrorType.NotFound => Results.NotFound(error),
                        ErrorType.Validation => Results.BadRequest(error),
                        ErrorType.Failure => Results.UnprocessableEntity(error),
                        ErrorType.Unexpected => Results.UnprocessableEntity(error),
                        _ => Results.UnprocessableEntity(error)
                    };
                });
            return response;
        }
        public static IResult ToErrorOrCreated<TValue>(this ErrorOr<TValue> result, string uri)
        {
            IResult response = Results.Problem();
            result.SwitchFirst(
                value => { response = Results.Created(uri, value); },
                error => {
                    response = error.Type switch
                    {
                        ErrorType.Conflict => Results.Conflict(error),
                        ErrorType.NotFound => Results.NotFound(error),
                        ErrorType.Validation => Results.BadRequest(error),
                        ErrorType.Failure => Results.UnprocessableEntity(error),
                        ErrorType.Unexpected => Results.UnprocessableEntity(error),
                        _ => Results.UnprocessableEntity(error)
                    };
                });
            return response;
        }
        public static IResult ToErrorOrAccepted<TValue>(this ErrorOr<TValue> result)
        {
            IResult response = Results.Problem();
            result.SwitchFirst(
                value => { response = Results.Accepted(value: value); },
                error => {
                    response = error.Type switch
                    {
                        ErrorType.Conflict => Results.Conflict(error),
                        ErrorType.NotFound => Results.NotFound(error),
                        ErrorType.Validation => Results.BadRequest(error),
                        ErrorType.Failure => Results.UnprocessableEntity(error),
                        ErrorType.Unexpected => Results.UnprocessableEntity(error),
                        _ => Results.UnprocessableEntity(error)
                    };
                });
            return response;
        }
        public static IResult ToErrorOrNoContent(this ErrorOr<object> result)
        {
            IResult response = Results.Problem();
            result.SwitchFirst(
                _ => { response = Results.NoContent(); },
                error => {
                    response = error.Type switch
                    {
                        ErrorType.Conflict => Results.Conflict(error),
                        ErrorType.NotFound => Results.NotFound(error),
                        ErrorType.Validation => Results.BadRequest(error),
                        ErrorType.Failure => Results.UnprocessableEntity(error),
                        ErrorType.Unexpected => Results.UnprocessableEntity(error),
                        _ => Results.UnprocessableEntity(error)
                    };
                });
            return response;
        }
    }
}
