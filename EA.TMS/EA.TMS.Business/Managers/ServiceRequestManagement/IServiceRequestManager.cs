using System.Collections.Generic;
using EA.TMS.Business.Core;
using EA.TMS.Common.BusinessObjects;

namespace EA.TMS.Business.Managers.ServiceRequestManagement
{
    public interface IServiceRequestManager : IActionManager
    {
        IEnumerable<TenantServiceRequest> GetAllTenantServiceRequests();
    }
}
