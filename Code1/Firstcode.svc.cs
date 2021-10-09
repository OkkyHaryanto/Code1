using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Code1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Firstcode" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Firstcode.svc or Firstcode.svc.cs at the Solution Explorer and start debugging.
    public class Firstcode : IFirstcode
    {
        public string Message()
        {
            return "OKKY HARYANTO 20190140052";
        }
    }
}
