using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Subscriber.core.Interface_Service;
using Subscriber.core.model;
using Subscriber.core.Response;


namespace Weight_Watchers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardController : ControllerBase
    {


        readonly ICardService _CardService;
        readonly IMapper _mapper;

        public CardController(ICardService cardService, IMapper mapper)
        {
            _CardService = cardService;
            _mapper = mapper;
        }

        [HttpGet("getById")]
        public Task<BaseResponseGeneric<CardModel>> GetCardById(int id)
        {
           return _CardService.GetCardById(id);
        }

    }
}
