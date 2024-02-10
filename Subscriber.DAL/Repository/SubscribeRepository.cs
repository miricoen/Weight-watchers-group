using Subscriber.core;
using Subscriber.core.Response;
using Subscriberr.core.Interface;
using Subscriberr.data;
using Subscriberr.data.model;

namespace Subscriber.DAL.Repository
{
    public class SubscribeRepository : ISubscriberRepository
    {
        readonly SubacriberContext _SubacriberContext;
        public SubscribeRepository(SubacriberContext subacriberContext)
        {
            _SubacriberContext = subacriberContext;
        }


        public async Task<BaseResponseGeneric<bool>> AddSubscriber(int idSub, int idCard, string firstName, string lastName,
         string email, string password, double height, double weight)
        {
            BaseResponseGeneric<bool> res = new BaseResponseGeneric<bool>();
            try
            {
                if (_SubacriberContext.Subscribers.Where(s => s.Email.Equals(email)).FirstOrDefault() != null)
                {
                    SubscriberTable subscriber = new SubscriberTable();
                    subscriber.Id = idSub;
                    subscriber.FirstName = firstName;
                    subscriber.LastName = lastName;
                    subscriber.Email = email;
                    subscriber.Password = password;

                    Card card = new Card();
                    card.Id = idCard;
                    card.SubscriberId = idSub;
                    card.OpenDate = DateTime.Now;
                    card.Height = height;
                    card.Weight = weight;
                    card.BMI = 0;
                    card.UpdateDate = DateTime.Now;

                    _SubacriberContext.Subscribers.Add(subscriber);
                    _SubacriberContext.Cards.Add(card);
                    _SubacriberContext.SaveChanges();
                    res.Data = true;
                    res.Messege = "Successfully added customer";
                }
                else
                {
                    res.Data = false;
                    res.Succeed = false;
                    res.Messege = "Unable to add, there is a customer with the same email address";
                }

            }
            catch (Exception ex)
            {
                throw new MyException(203, "subscriber", ex.Message);
            }

            //res.Succeed = false;
            //res.Messege = "you cant enter";
            return res;
        }


        public async Task<BaseResponseGeneric<int>> Login(int id, string password)
        {
            BaseResponseGeneric<int> res = new BaseResponseGeneric<int>();

            if (_SubacriberContext.Subscribers.Where(s => s.Id.Equals(id) && s.Password.Equals(password)).FirstOrDefault() == null)
            {

                int cid = _SubacriberContext.Cards.Where(s => s.SubscriberId.Equals(id)).FirstOrDefault().Id;

                res.Data = cid;
                res.Succeed = true;
                res.Messege = "subscriber found";
            }
            else
            {
                throw new MyException(400, "Subscriber", "there is no subscriber like that");
            }
            return res;
        }

    }


}
