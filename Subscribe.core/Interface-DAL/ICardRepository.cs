using Subscriber.core.model;
using Subscriber.core.Response;

namespace Subscribe.core.Interface
{
    public interface ICardRepository
    {

        public Task<BaseResponseGeneric<CardModel>> GetCardById(int id);


    }
}
