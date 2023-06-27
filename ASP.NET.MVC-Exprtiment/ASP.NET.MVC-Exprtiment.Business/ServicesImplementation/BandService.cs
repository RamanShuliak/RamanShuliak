using ASP.NET.MVC_Exprtiment.Core;
using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.Data.Abstractions;
using ASP.NET.MVC_Exprtiment.Data.CQS.Commands;
using ASP.NET.MVC_Exprtiment.Data.CQS.Queries;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ASP.NET.MVC_Exprtiment.Business.ServicesImplementation
{
    public class BandService: IBandService
    {
        private readonly MusicBandsContext _musicBandsContext;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IMediator _mediator;

        public BandService(MusicBandsContext musicBandsContext,
            IMapper mapper, IConfiguration configuration, 
            IUnitOfWork unitOfWork, IMediator mediator)
        {
            _musicBandsContext = musicBandsContext;
            _mapper = mapper;
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        public async Task<List<BandDto>> GetBandsByPageNumberAndPageSizeAsync(int pageNumber, int pageSize)
        {
            var bandList = await _unitOfWork.Bands
                .Get()
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .Select(band => _mapper.Map<BandDto>(band))
                .ToListAsync();

            return bandList;
        }

        public async Task<BandDto> GetBandByIdAsync(Guid id)
        {

            var band = await _mediator.Send(new GetBandByIdQuery()
            {
                BnadId = id
            });

            var bandDto = _mapper.Map<BandDto>(band);

            return bandDto;
        }

        public async Task<LabelDto> GetLabelByNameAsync(string name)
        {

            var label = await _unitOfWork.Labels
                .FindBy(label =>  label.Name.Equals(name))
                .FirstOrDefaultAsync();

            var labelDto = _mapper.Map<LabelDto>(label);

            if (label == null)
            {
                return null;
            }
            else 
            {
                return labelDto;
            }

        }

        public async Task AddBandAsync(BandDto bandDto)
        {
            await _mediator.Send(new AddBandAsyncCommand()
            {
                Band = bandDto
            });
        }

        public async Task<int> EditBandAsync(BandDto bandDto)
        {

            if (bandDto != null)
            {
                var entityInDataBase = await _unitOfWork.Bands.GetByIdAsync(bandDto.Id);

                entityInDataBase.Name = bandDto.Name;
                entityInDataBase.Country = bandDto.Country;
                entityInDataBase.DateOfCreation = bandDto.DateOfCreation;
                entityInDataBase .Description = bandDto.Description;
                entityInDataBase.MainText = bandDto.MainText;
                entityInDataBase.LabelId = bandDto.LabelId;

                var resultOfAdding = await _unitOfWork.CommitAsync();
                return resultOfAdding;
            }
            else
            {
                throw new ArgumentException(nameof(bandDto));
            }
        }

        public async Task<bool> IsBandAlreadyExistAsync (string name)
        {
            var result = await _unitOfWork.Bands
                .FindBy(band => band.Name.Equals(name))
                .FirstOrDefaultAsync();

            if(result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        } 

        public async Task<int> DeleteBandAsync(Guid id)
        {
            var bandForDelete = await _unitOfWork.Bands.GetByIdAsync(id);

            _unitOfWork.Bands.Remove(bandForDelete);

            return await _unitOfWork.CommitAsync();
        }
    }
}
