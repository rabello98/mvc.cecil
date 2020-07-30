using MVCCecil.Structure.Contract;
using System;

namespace MVCCecil.MVC
{
    public class ControllerConfig : IAssemblyControllerConfig
    {
        public string Configuration { get; set; }
        public ControllerConfig() { }
        public ControllerConfig(String configuration)
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
