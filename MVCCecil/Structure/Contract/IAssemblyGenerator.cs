using System;

namespace MVCCecil.Structure.Contract
{
    public interface IAssemblyGenerator
    {
        IAssemblyModelConfig ModelConfigurator { get; set; }
        IAssemblyViewModelConfig ViewModelConfigurator { get; set; }
        IAssemblyControllerConfig ControllerConfigurator { get; set; }
        void Generate();
    }
}
