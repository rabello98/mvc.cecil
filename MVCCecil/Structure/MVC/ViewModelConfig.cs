using MVCCecil.Structure.Contract;
using System;

namespace MVCCecil.Structure.MVC
{
    public class ViewModelConfig : IAssemblyViewModelConfig
    {
        public string Configuration { get; set; }
        public ViewModelConfig() { }
        public ViewModelConfig(String configuration)
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
