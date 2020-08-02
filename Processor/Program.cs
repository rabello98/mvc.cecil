using MVCCecil;

namespace Processor
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = @"{
                ModelConfig: {},
                ViewModelConfig: {},
                ControllerConfig: {}
            }";

            var generator = new AssemblyGenerator(config);
            generator.Generate();
        }
    }
}
