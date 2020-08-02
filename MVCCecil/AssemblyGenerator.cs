using Mono.Cecil;
using MVCCecil.Structure.Contract;
using MVCCecil.MVC;
using System;
using Newtonsoft.Json;
using MVCCecil.Structure.StructureModel;
using Newtonsoft.Json.Linq;

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
            DeserializeMasterConfig(masterConfig);
        }

        public void SetConfig (string masterConfig)
        {
            DeserializeMasterConfig(masterConfig);
        }
        public void DeserializeMasterConfig(string masterConfig)
        {
            var config = JsonConvert.DeserializeObject<BaseStruct>(masterConfig);

            ModelConfigurator.BaseConfig = config;
            ViewModelConfigurator.BaseConfig = config;
            ControllerConfigurator.BaseConfig = config;
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
