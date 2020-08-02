using MVCCecil.Structure.StructureModel;

namespace MVCCecil.Structure.Contract
{
    public interface IAssemblyControllerConfig : IAssemblyConfig
    {
        ControllerStructure StrucutureConfig { get; set; }
    }
}
