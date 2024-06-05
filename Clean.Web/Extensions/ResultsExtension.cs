using ErrorOr;
using Microsoft.AspNetCore.Http;

namespace Clean.Web.Extensions
{
    /// <summary>
    /// The results extension class
    /// </summary>
    public static class ResultsExtension
    {

        /// <summary>
        /// Returns the error or ok using the specified result
        /// </summary>
        /// <typeparam name="TValue">The value</typeparam>
        /// <param name="result">The result</param>
        /// <returns>The response</returns>
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
        /// <summary>
        /// Returns the error or created using the specified result
        /// </summary>
        /// <typeparam name="TValue">The value</typeparam>
        /// <param name="result">The result</param>
        /// <param name="uri">The uri</param>
        /// <returns>The response</returns>
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
        /// <summary>
        /// Returns the error or accepted using the specified result
        /// </summary>
        /// <typeparam name="TValue">The value</typeparam>
        /// <param name="result">The result</param>
        /// <returns>The response</returns>
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
        /// <summary>
        /// Returns the error or no content using the specified result
        /// </summary>
        /// <param name="result">The result</param>
        /// <returns>The response</returns>
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
