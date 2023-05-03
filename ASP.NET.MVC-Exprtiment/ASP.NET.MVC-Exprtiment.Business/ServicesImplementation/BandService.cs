using ASP.NET.MVC_Exprtiment.Core;
using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;

namespace ASP.NET.MVC_Exprtiment.Business.ServicesImplementation
{
    public class BandService: IBandService
    {
        private readonly BandStorage _bandStorage;

        public BandService(BandStorage bandStorage)
        {
            _bandStorage = bandStorage;
        }

        public async Task<List<BandDto>> GetBandsByPageNumberAndPageSize(int pageNumber, int pageSize)
        {
            List<BandDto> list;

            list = _bandStorage.BandsList
                .Skip(pageNumber*pageSize)
                .Take(pageSize).ToList();

            return list;
        }
    }
}
