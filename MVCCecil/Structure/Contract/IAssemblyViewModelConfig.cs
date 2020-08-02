using MVCCecil.Structure.StructureModel;

namespace MVCCecil.Structure.Contract
{
    public interface IAssemblyViewModelConfig : IAssemblyConfig
    {
        ViewModelStructure StrucutureConfig { get; set; }
    }
}
