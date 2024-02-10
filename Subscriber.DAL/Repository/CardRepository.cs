using Subscribe.core.Interface;
using Subscriber.core.model;
using Subscriber.core.Response;
using Subscriberr.data;
using Subscriberr.data.model;

namespace Subscriber.DAL.Repository
{
    public class CardRepository : ICardRepository
    {
        readonly SubacriberContext _SubacriberContext;
        public CardRepository(SubacriberContext subacriberContext)
        {
            _SubacriberContext = subacriberContext;
        }


        public async Task<BaseResponseGeneric<CardModel>> GetCardById(int id)
        {
            BaseResponseGeneric<CardModel> res = new BaseResponseGeneric<CardModel>();

            Card card = _SubacriberContext.Cards.Where(s => s.SubscriberId.Equals(id)).FirstOrDefault();
            CardModel cardToRet = new CardModel(id, card.BMI, card.Height, card.Weight, card.UpdateDate);


            res.Data = cardToRet;
            res.Succeed = true;
            res.Messege = "subscriber found";

            return res;
        }
    }

}
