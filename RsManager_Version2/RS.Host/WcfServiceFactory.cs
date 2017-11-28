using DAL.Repository.Service.Implementation;
using DAL.Repository.Service.Interface;
using Microsoft.Practices.Unity;
using ResultBusinessLogic.Implementation;
using ResultBusinessLogic.Interface;
using RS.Implementation.Implementation;
using RS.Implementation.Interface;
using Unity.Wcf;

namespace RS.Host
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            //Business Logic
            container.RegisterType<ISystemSpecificRules, SystemSpecificRules>();
          
            //Unit of Work
            container.RegisterType<IAdminContext, AdminContext>();
            //Services
            container.RegisterType<IPortalAdminService, PortalAdminService>();
        }
    }    
}