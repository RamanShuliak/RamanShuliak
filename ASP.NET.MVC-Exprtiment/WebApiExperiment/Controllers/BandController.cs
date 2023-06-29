using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using AutoMapper;
using Hangfire;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExperiment.Models.Requests;

namespace WebApiExperiment.Controllers
{
    /// <summary>
    /// Controller for work with bands
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BandController : ControllerBase
    {
        private readonly IBandService _bandService;
        private readonly IMapper _mapper;

        public BandController(IBandService bandService, IMapper mapper)
        {
            _bandService = bandService;
            _mapper = mapper;
        }

        /// <summary>
        /// Get band by specific Id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Authorize]
        [ProducesResponseType(typeof(BandDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetBandByIdAsync(Guid id)
        {
            var band = await _bandService.GetBandByIdAsync(id);

            if (band == null)
            {
                return NotFound();
            }
            return Ok(band);
        }

        /// <summary>
        /// Add band
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddBandsAsync([FromBody]AddBandsRequestModel model)
        {
            if(model != null)
            {
                var dto = new BandDto()
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                    Country = model.Country,
                    DateOfCreation = DateTime.Now,
                    Description = model.Description,
                    MainText = model.MainText
                };

                await _bandService.AddBandAsync(dto);

                return Created(nameof(GetBandByIdAsync), new {id = dto.Id});
            }

            return BadRequest();
        }

        /// <summary>
        /// Delete band
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteBand(Guid id)
        {
            try
            {
                await _bandService.DeleteBandAsync(id);

                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
