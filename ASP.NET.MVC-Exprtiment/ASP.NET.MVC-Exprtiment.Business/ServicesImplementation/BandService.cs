using ASP.NET.MVC_Exprtiment.Core;
using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ASP.NET.MVC_Exprtiment.Business.ServicesImplementation
{
    public class BandService: IBandService
    {
        private readonly MusicBandsContext _musicBandsContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public BandService(MusicBandsContext musicBandsContext, IMapper mapper, IConfiguration configuration)
        {
            _musicBandsContext = musicBandsContext;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<List<BandDto>> GetBandsByPageNumberAndPageSizeAsync(int pageNumber, int pageSize)
        {
            var bandList = await _musicBandsContext.Bands
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .Select(band => _mapper.Map<BandDto>(band))
                .ToListAsync();

            return bandList;
        }

        public async Task<BandDto> GetBandByIdAsync(Guid id)
        {

            var band = await _musicBandsContext.Bands
                .FirstOrDefaultAsync(band => band.Id.Equals(id));

            var bandDto = _mapper.Map<BandDto>(band);

            return bandDto;
        }

        public async Task<LabelDto> GetLabelByNameAsync(string name)
        {
                var label = await _musicBandsContext.Labels
                    .FirstOrDefaultAsync(label => label.Name.Equals(name));

            if(label == null)
            {
                return null;
            }

                var labelDto = _mapper.Map<LabelDto>(label);

                return labelDto;
        }

        public async Task<int> AddBandAsync(BandDto bandDto)
        {
            var bandEntity = _mapper.Map<Band>(bandDto);

            if (bandEntity != null)
            {
                await _musicBandsContext.AddAsync(bandEntity);
                var resultOfAdding = await _musicBandsContext.SaveChangesAsync();
                return resultOfAdding;
            }
            else 
            {
                throw new ArgumentException(nameof(bandDto));
            }
        }

        public async Task<int> EditBandAsync(BandDto bandDto)
        {

            if (bandDto != null)
            {
                var entityInDataBase = await _musicBandsContext.Bands
                    .FirstOrDefaultAsync(band => band.Id.Equals(bandDto.Id));

                entityInDataBase.Name = bandDto.Name;
                entityInDataBase.Country = bandDto.Country;
                entityInDataBase.DateOfCreation = bandDto.DateOfCreation;
                entityInDataBase .Description = bandDto.Description;
                entityInDataBase.MainText = bandDto.MainText;
                entityInDataBase.LabelId = bandDto.LabelId;

                var resultOfAdding = await _musicBandsContext.SaveChangesAsync();
                return resultOfAdding;
            }
            else
            {
                throw new ArgumentException(nameof(bandDto));
            }
        }
    }
}
