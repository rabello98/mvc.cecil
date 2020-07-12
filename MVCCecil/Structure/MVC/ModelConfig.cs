using MVCCecil.Structure.Contract;
using System;

namespace MVCCecil.Structure.MVC
{
    public class ModelConfig : IAssemblyModelConfig
    {
        public string Configuration { get; set; }
        public ModelConfig() { }
        public ModelConfig(String configuration)
        {
            Configuration = configuration;
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
    }
}
