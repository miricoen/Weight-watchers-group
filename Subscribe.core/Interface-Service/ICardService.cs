using Subscriber.core.model;
using Subscriber.core.Response;


namespace Subscriber.core.Interface_Service
{
    public interface ICardService
    {
        public Task<BaseResponseGeneric<CardModel>> GetCardById(int id);

    }
}
