using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;

namespace PULSE.Services.Interfaces
{
    public interface IAvailableSizeService : ICRUDService<AvailableSize, AvailableSizeSearchObject, AvailableSizeUpsertRequest, AvailableSizeUpsertRequest>
    {
    }
}
