using Gateway.ErrorLib.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway.ErrorLib
{
    public interface IGatewayErrorCheck
    {
        List<Error> ListErrors();
        Error Find(string errorId);
    }
}
