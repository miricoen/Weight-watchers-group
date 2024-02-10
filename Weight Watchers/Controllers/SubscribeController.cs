using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Subscriber.core.Interface_Service;
using Subscriber.core.Response;

namespace Weight_Watchers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscribeController:ControllerBase
    {

        readonly ISubscribeService _SubscribeService;
        readonly IMapper _mapper;
        public SubscribeController(ISubscribeService subscribeService, IMapper mapper)
        {
            _SubscribeService = subscribeService;
            _mapper = mapper;
        }

        [HttpPost("AddSubscriber")]
        public Task<BaseResponseGeneric<bool>> AddSubscriber(int idSub, int idCard, string firstName, string lastName,
              string email, string password, double height, double weight)
        {
            return _SubscribeService.AddSubscriber(idSub, idCard, firstName, lastName, email, password, height, weight);
        
        }

        [HttpPost("login")]
        public Task<BaseResponseGeneric<int>> Login(int id, string password)
        {
            return _SubscribeService.Login(id, password);
        }



    }
}
