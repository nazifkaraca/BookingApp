using BookingApp.Business.Operations.Feature;
using BookingApp.Business.Operations.User.Dtos;
using BookingApp.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureService _featureService;

        public FeaturesController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpPost]
        public async Task<IActionResult> AddFeature(AddFeatureRequest request)
        {
            var addFeatureDto = new AddFeatureDto
            {
                Title = request.Title,
            };
        }
    }
}
