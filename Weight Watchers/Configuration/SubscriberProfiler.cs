using AutoMapper;
using Subscriber.core.DTO;
using Subscriberr.data.model;

namespace Subscriber.Weight_Watchers.Configuration
{
    public class SubscriberProfiler : Profile
    {
        public SubscriberProfiler()
        {
            CreateMap<SubscriberTable, SubscriberDTO>().ReverseMap();
            CreateMap<Card, CardDTO>().ReverseMap();
        }
    }
}
