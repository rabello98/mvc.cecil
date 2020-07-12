using System;

namespace MVCCecil.Structure.Contract
{
    public interface IAssemblyConfig
    {
        String Configuration { get; set; }
        void Run();
        void Run(String config);
    }
}
