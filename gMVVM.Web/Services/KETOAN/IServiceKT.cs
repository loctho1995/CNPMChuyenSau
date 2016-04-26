using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace gMVVM.Web.Services.KETOAN
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceKT" in both code and config file together.
    [ServiceContract]
    public interface IServiceKT
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        void TestKT();
    }
}
