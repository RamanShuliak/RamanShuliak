using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Core.Abstractions
{
    public interface IBandService
    {
        Task<List<BandDto>> GetBandsByPageNumberAndPageSize(int pageNumber, int pageSize);
        Task<BandDto> GetBandById(Guid id);
        Task<LabelDto> GetLabelByName(string name);
        Task<int> AddBandAsync(BandDto bandDto);
    }
}
