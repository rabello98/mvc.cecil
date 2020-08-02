using MVCCecil.Structure.Contract;
using MVCCecil.Structure.StructureModel;
using Newtonsoft.Json;
using System;

namespace MVCCecil.MVC
{
    public class ModelConfig : IAssemblyModelConfig
    {
        private String _configuration;
        public String Configuration
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
                Configuration  = value.ModelConfig.ToString();
            }
        }
        public ModelStructure StrucutureConfig { get; set; }
        public ModelConfig() { }
        public ModelConfig(String configuration)
        {
            Configuration = configuration;
        }
        public ModelConfig(BaseStruct baseConfig)
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
            StrucutureConfig = JsonConvert.DeserializeObject<ModelStructure>(Configuration);
        }
    }
}
