namespace UserLoginBE.Common
{
    public class BaseResponse<T>
    {
        public T Data { get; set; }
        public int Status { get; set; } = 200;
        public string ErrorMessage { get; set; }
        public bool IsError { get; set; }
    }
}
