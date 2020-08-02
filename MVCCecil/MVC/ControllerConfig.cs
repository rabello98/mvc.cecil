using MVCCecil.Structure.Contract;
using MVCCecil.Structure.StructureModel;
using Newtonsoft.Json;
using System;

namespace MVCCecil.MVC
{
    public class ControllerConfig : IAssemblyControllerConfig
    {
        private String _configuration;
        public string Configuration
        {
            get
            {
                return _configuration;
            }
            set
            {
                _configuration = value;
                ParseConfig();
            }
        }

        private BaseStruct _baseConfig;
        public BaseStruct BaseConfig
        {
            get
            {
                return _baseConfig;
            }
            set
            {
                Configuration = value.ControllerConfig.ToString();
            }
        }

        public ControllerStructure StrucutureConfig { get; set; }

        public ControllerConfig() { }
        public ControllerConfig(String configuration)
        {
            Configuration = configuration;
        }

        public ControllerConfig(BaseStruct baseConfig)
        {
            BaseConfig = baseConfig;
        }

        public void Run()
        {
            Run(Configuration);
        }

        public void Run(String config)
        {
            if (Configuration != config)
                Configuration = config;


        }
        public void ParseConfig()
        {
            StrucutureConfig = JsonConvert.DeserializeObject<ControllerStructure>(Configuration);
        }
    }
}
