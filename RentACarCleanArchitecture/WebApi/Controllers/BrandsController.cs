using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Brands.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IMediator _mediator;

        public BrandsController(IMediator mediator) {
            _mediator = mediator;
        }

        [HttpPost]
        //Meaditr CreateBrandCommand'in handlerını arar ve o handlerı çalıştırır
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand) //elimde marka ismi olan command var 
        {
            //[FromBody] CreateBrandCommand createBrandCommand) marka commandını ver demek CreateBrandCommand'da da name var. Yani swaggerdan name gelecek.
            //[FromBody] CreateBrandCommand createBrandCommand) Frombody swaggerdaki jasonu CreateBrandCommand createBrandCommand mapliyor. Alanları birbirine eşitliyor yani
            CreatedBrandResponse response = await _mediator.Send(createBrandCommand); //createBrandCommand bunun handlerı çalışır
            //_mediator : createBrandCommand'in handlerını buluyor.
            return Ok(response);

        }

    } 
}

