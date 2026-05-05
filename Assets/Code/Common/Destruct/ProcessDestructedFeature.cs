using Code.Common.Destruct.Systems;
using Code.Infrastructure.Systems;

namespace Code.Common.Destruct
{
    public class ProcessDestructedFeature : Feature
    {
        public ProcessDestructedFeature(ISystemFactory systems)
        {
            Add(systems.Create<SelftDestructTimerSystem>());
            
            Add(systems.Create<CleanupGameDestructedViewSystem>());
            Add(systems.Create<CleanupGameDestructedSystem>());
        }
    }
}