using MVCCecil.Structure.Contract;
using MVCCecil.Structure.StructureModel;
using Newtonsoft.Json;
using System;

namespace MVCCecil.MVC
{
    public class ViewModelConfig : IAssemblyViewModelConfig
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
                Configuration = value.ViewModelConfig.ToString();
            }
        }

        public ViewModelStructure StrucutureConfig { get; set; }

        public ViewModelConfig() { }
        public ViewModelConfig(String configuration)
        {
            Configuration = configuration;
        }

        public ViewModelConfig(BaseStruct baseConfig)
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
            StrucutureConfig = JsonConvert.DeserializeObject<ViewModelStructure>(Configuration);
        }
    }
}
