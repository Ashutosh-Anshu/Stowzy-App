namespace user_gateway.Common.Responses
{
    // Base API Response Class
    public class ApiResponse
    {
        public ApiResponse(bool isSuccess, int statusCode, object? data = null)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            Data = data;
        }

        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public object? Data { get; set; }
    }

    // API Response with Message
    public class ApiMessageResponse : ApiResponse
    {
        public ApiMessageResponse(string message, bool isSuccess, int statusCode, object? data = null)
            : base(isSuccess, statusCode, data)
        {
            Message = message;
        }

        public string Message { get; set; }
    }

}
