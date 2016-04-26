using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace gMVVM.Web.Services.Management.Interfaces.AssCommon
{
 

    [ServiceContract]
    public interface ICM_DOMAIN
    {

        [OperationContract]
        CM_DOMAIN_InsResult InsertDOMAIN(CM_DOMAIN data);

        [OperationContract]
        string UpdateDOMAIN(CM_DOMAIN data);
    }
}