using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.KafkaConfig
{
    public class KafkaConfigurations
    {
        private readonly IConfiguration _configuration;

        public string KafkaAddress { get; }

        public KafkaConfigurations(IConfiguration configuration)
        {
            _configuration = configuration;

            KafkaAddress = _configuration["KafkaAdress"];
        }
    }
}
