using Subscriber.core.Interface_Service;
using Subscriber.core.Response;
using Subscriber.DAL.Repository;
using Subscriberr.core.Interface;


namespace Subscriber.Services
{
    public class SubscribeService : ISubscribeService
    {
        readonly ISubscriberRepository _SubacribeRepository;
        public SubscribeService(ISubscriberRepository subacribeeRepository)
        {
            _SubacribeRepository = subacribeeRepository;
        }


        public Task<BaseResponseGeneric<bool>> AddSubscriber(int idSub, int idCard, string firstName, string lastName,
               string email, string password, double height, double weight)
        {
            return _SubacribeRepository.AddSubscriber(idSub, idCard, firstName, lastName, email,
                password, height, weight);
        }


        public Task<BaseResponseGeneric<int>> Login(int id, string password)
        {
            return _SubacribeRepository.Login(id, password);
        }
    }
}
