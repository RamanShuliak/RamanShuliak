using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET.MVC_Exprtiment.Core.Abstractions
{
    public interface ILabelService
    {
        Task<List<LabelDto>> GetLabelByPageNumberAndPageSizeAsync(int pageNumber, int pageSize);
    }
}
