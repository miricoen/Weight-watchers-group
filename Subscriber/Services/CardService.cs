using Subscribe.core.Interface;
using Subscriber.core.Interface_Service;
using Subscriber.core.model;
using Subscriber.core.Response;
using Subscriber.DAL.Repository;

namespace Subscriber_.Services
{
    public class CardService : ICardService
    {
        readonly ICardRepository _CardRepository;
        public CardService(ICardRepository cardRepository)
        {
            _CardRepository = cardRepository;
        }

        public Task<BaseResponseGeneric<CardModel>> GetCardById(int id)
        {
            return _CardRepository.GetCardById(id);
        }


    }
}
