using EA.TMS.Business.Managers.ServiceRequestManagement;
using EA.TMS.Business.Managers.TenantManagement;

namespace EA.TMS.Business.Core
{
    public class BusinessManagerFactory
    {
        IServiceRequestManager _serviceRequestManager;
        ITenantManager _tenantManager;

        public BusinessManagerFactory(
            IServiceRequestManager serviceRequestManager = null, ITenantManager tenantManager = null)
        {
            _serviceRequestManager = serviceRequestManager;
            _tenantManager = tenantManager;
        }

        public IServiceRequestManager GetServiceRequestManager()
        {
            return _serviceRequestManager;
        }

        public ITenantManager GetTenantManager()
        {
            return _tenantManager;
        }
    }
}
