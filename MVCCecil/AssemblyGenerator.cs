using Mono.Cecil;
using MVCCecil.Structure.Contract;
using MVCCecil.MVC;
using System;

namespace MVCCecil
{
    public class AssemblyGenerator : IAssemblyGenerator
    {
        public IAssemblyModelConfig ModelConfigurator { get; set; }
        public IAssemblyViewModelConfig ViewModelConfigurator { get; set; }
        public IAssemblyControllerConfig ControllerConfigurator { get; set; }

        public AssemblyGenerator() 
        {
            CreateInstance();
        }
        public AssemblyGenerator(IAssemblyModelConfig modelConfig, IAssemblyViewModelConfig viewModelConfig,
            IAssemblyControllerConfig controllerConfig)
        {
            ModelConfigurator = modelConfig;
            ViewModelConfigurator = viewModelConfig;
            ControllerConfigurator = controllerConfig;
        }
        public AssemblyGenerator(string masterConfig)
        {
            CreateInstance();
        }

        public void SetConfig (string masterConfig)
        {

        }

        public void CreateInstance ()
        {
            ModelConfigurator = new ModelConfig();
            ViewModelConfigurator = new ViewModelConfig();
            ControllerConfigurator = new ControllerConfig();
        }

        public void Generate()
        {
            ModelConfigurator.Run();
            ViewModelConfigurator.Run();
            ControllerConfigurator.Run();
        }

        public void Example ()
        {
            var webDefinition = AssemblyDefinition.ReadAssembly("SoftwareHouse.dll");
            var module = webDefinition.MainModule;

            var type = new TypeDefinition(
                "SoftwareHouse.Models",
                "Customer",
                TypeAttributes.Public);

            var methodReturnType = module.ImportReference(typeof(String));
            var method = new MethodDefinition("Sum", MethodAttributes.Public, methodReturnType);
            type.Methods.Add(method);
            module.Types.Add(type);

            webDefinition.Write("SoftwareHouseMod.dll");
        }
    }
}
