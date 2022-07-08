using PULSE.Model.SearchObjects;
using PULSE.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PULSE.Model;

namespace PULSE.Services.Interfaces
{
    public interface IStaffService : ICRUDService<Staff, StaffSearchObject, StaffInsertRequest, StaffUpdateRequest>
    {
        Model.Staff Login(string username, string password);
    }
}
