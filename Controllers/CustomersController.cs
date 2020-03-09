using Mapper.Interfaces;
using Mapper.Entity;
using Microsoft.AspNetCore.Mvc;
using Interfaces;
using AutoMapper;

namespace Mapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IClient _client;
        private readonly IClient01 _client01;

        IMapper _mapper;
        public CustomersController(IMapper mapper, IClient client, IClient01 client01)
        {
            _mapper = mapper;
            _client = client;
            _client01 = client01;
        }

        [HttpGet("client01")]
        public Client01 GetClient01()
        {

            var usuario = _client01.GetClient01();

            var viewModel = _mapper.Map<Client01>(usuario);

            return viewModel;
        }


        [HttpGet("client")]
        public Client01 GetClient()
        {

            var usuario = _client.GetClient();

            var viewModel = _mapper.Map<Client01>(usuario);

            return viewModel;
        }

        /*

                [HttpGet()]
                public string GetTest()
                => "Hello World";
                */
    }
}
