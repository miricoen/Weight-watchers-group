namespace Subscriber.core.Response
{
    public class BaseResponse
    {
        public bool Succeed { get; set; }
        public string Messege { get; set; }

        public BaseResponse()
        {
            Succeed = true;
        }

    }
}
