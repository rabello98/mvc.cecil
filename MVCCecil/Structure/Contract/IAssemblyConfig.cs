using MVCCecil.Structure.StructureModel;
using System;

namespace MVCCecil.Structure.Contract
{
    public interface IAssemblyConfig
    {
        BaseStruct BaseConfig { get; set; }
        String Configuration { get; set; }
        void Run();
        void Run(String config);
        void ParseConfig();
    }
}
