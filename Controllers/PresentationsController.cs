using System;
using Microsoft.AspNetCore.Mvc;
using aec_webapi_ef.Presentation;

namespace aec_webapi_ef.Controllers{

    [ApiController]

    public class PresentationsController : ControllerBase{

        [HttpGet]
        [Route("/")]
        public PresentationView Get()
        {
            return new PresentationView();
        }
    }
}