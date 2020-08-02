using MVCCecil.Structure.StructureModel;

namespace MVCCecil.Structure.Contract
{
    public interface IAssemblyModelConfig : IAssemblyConfig
    {
        ModelStructure StrucutureConfig {get; set;}
    }
}
