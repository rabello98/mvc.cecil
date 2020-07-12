using System;

namespace MVCCecil.Structure.Contract
{
    public interface IAssemblyGenerator
    {
        String ModelConfig { get; set; }
        String ViewModelConfig { get; set; }
        String ControllerConfig { get; set; }
        IAssemblyModelConfig ModelConfigurator { get; set; }
        IAssemblyViewModelConfig ViewModelConfigurator { get; set; }
        IAssemblyControllerConfig ControllerConfigurator { get; set; }
        void Generate();
    }
}
