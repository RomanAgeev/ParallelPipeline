using System.Threading;

namespace ParallelPipeline {
    public class CancellationToken {
        volatile bool isCancelled = false;

        public bool IsCancelled => isCancelled;
        
        public void Cancel() {
            isCancelled = true;
        }
    }
}