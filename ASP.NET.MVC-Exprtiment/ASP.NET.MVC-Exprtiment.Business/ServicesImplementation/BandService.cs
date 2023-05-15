﻿using ASP.NET.MVC_Exprtiment.Core;
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

        public async Task<List<BandDto>> GetBandsByPageNumberAndPageSize(int pageNumber, int pageSize)
        {
            var myApiKey = _configuration.GetSection("UserSecret")["MyApiKey"];

            var myPassword = _configuration["UserSecret:PasswordSalt"];

            var bandList = await _musicBandsContext.Bands
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .Select(band => _mapper.Map<BandDto>(band))
                .ToListAsync();

            return bandList;
        }

        public async Task<BandDto> GetBandById(Guid id)
        {
            var bands = await _musicBandsContext.Bands
                .Select(band => _mapper.Map<BandDto>(band))
                .ToListAsync();

            var band = bands.FirstOrDefault(band => band.Id.Equals(id));

            return band;
        }

        public async Task<LabelDto> GetLabelByName(string name)
        {
            var labels = await _musicBandsContext.Labels
                .Select(label => _mapper.Map<LabelDto>(label))
                .ToListAsync();

            var label = labels.FirstOrDefault(label => label.Name.Equals(name));

            return label;
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
    }
}
