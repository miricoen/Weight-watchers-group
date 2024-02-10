using Subscriber.core.Response;

namespace Subscriber.core.Interface_Service
{
    public interface ISubscribeService
    {
        public Task<BaseResponseGeneric<bool>> AddSubscriber(int idSub, int idCard, string firstName, string lastName,
              string email, string password, double height, double weight);


        public Task<BaseResponseGeneric<int>> Login(int id, string password);
    }
}
