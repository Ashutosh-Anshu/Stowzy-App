namespace user_gateway.Common.Responses
{
    public class ErrorResponse : ApiMessageResponse
    {
        public ErrorResponse(List<string>? errors, int statusCode, string message = "An error occurred")
            : base(message, false, statusCode)
        {
            Errors = errors;
        }

        public List<string>? Errors { get; set; }
    }
}
