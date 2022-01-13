using Gateway.ErrorLib.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway.ErrorLib
{
    public class GatewayErrorCheck:IGatewayErrorCheck
    {
        IConfiguration _configuration;

        List<Error> errorList = new List<Error>();
        public GatewayErrorCheck()
        {
           
            var builder = new ConfigurationBuilder()
                .AddJsonFile("ErrorConfig.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            _configuration = builder.Build();

            errorList = _configuration.GetSection(nameof(Error)).Get<List<Error>>();
        
        }

        public List<Error> ListErrors()
        {
            try
            {
                return errorList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Error Find(string errorId)
        {

            try
            {
                var error = errorList.FirstOrDefault(c => c.Id == errorId);
                return error;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
