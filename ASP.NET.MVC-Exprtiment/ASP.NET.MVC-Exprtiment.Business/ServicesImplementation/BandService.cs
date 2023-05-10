using ASP.NET.MVC_Exprtiment.Core;
using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET.MVC_Exprtiment.Business.ServicesImplementation
{
    public class BandService: IBandService
    {
        private readonly MusicBandsContext _musicBandsContext;
        private readonly IMapper _mapper;

        public BandService(MusicBandsContext musicBandsContext, IMapper mapper)
        {
            _musicBandsContext = musicBandsContext;
            _mapper = mapper;
        }

        public async Task<List<BandDto>> GetBandsByPageNumberAndPageSize(int pageNumber, int pageSize)
        {

            var bandList = await _musicBandsContext.Bands
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .Select(band => _mapper.Map<BandDto>(band))
                .ToListAsync();

            return bandList;
        }

        public async Task<BandDto> GetBandById(Guid id)
        {
            var band = new BandDto();
                //_bandStorage.BandsList.FirstOrDefault(b => b.Id.Equals(id));

            return band;
        }
    }
}
