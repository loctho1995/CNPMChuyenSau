using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace gMVVM.Web.Services.KETOAN
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceKT" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceKT.svc or ServiceKT.svc.cs at the Solution Explorer and start debugging.
   [AspNetCompatibilityRequirements(
        RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiceKT : IServiceKT
    {
        public void DoWork()
        {
        }


        public void TestKT()
        {
            
        }
    }
}
