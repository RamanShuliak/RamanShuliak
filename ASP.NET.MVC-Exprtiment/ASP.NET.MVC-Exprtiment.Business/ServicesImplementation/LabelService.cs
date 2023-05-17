using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.DataBase;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Business.ServicesImplementation
{
    public class LabelService : ILabelService
    {
        private readonly MusicBandsContext _musicBandsContext;
        private readonly IMapper _mapper;

        public LabelService(MusicBandsContext musicBandsContext, IMapper mapper)
        {
            _musicBandsContext = musicBandsContext;
            _mapper = mapper;
        }

        public async Task<List<LabelDto>> GetLabelByPageNumberAndPageSizeAsync(int pageNumber, int pageSize)
        {
            var labelsList = await _musicBandsContext.Labels
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .Select(label => _mapper.Map<LabelDto>(label))
                .ToListAsync();

            return labelsList;
        }
    }
}
