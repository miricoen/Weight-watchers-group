using Subscriber.core.Response;

namespace Subscriberr.core.Interface
{
    public interface ISubscriberRepository
    {

        //  public void AddSubscriber(SubscriberTable subscriber);
        //public Task<BaseResponseGeneric<bool>> AddSubscriber(SubscriberTable subscriberModle);
        public Task<BaseResponseGeneric<bool>> AddSubscriber(int idSub, int idCard, string firstName, string lastName,
        string email, string password, double height, double weight);

        public Task<BaseResponseGeneric<int>> Login(int id, string password);

    }
}

