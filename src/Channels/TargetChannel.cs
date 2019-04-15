using System;
using Guards;

namespace ParallelPipeline.Channels {
    public class TargetChannel<T> : IWritableChannel<T> {
        readonly Action<T> action;

        public  TargetChannel(Action<T> action) {
            Guard.NotNull(action, nameof(action));
            
            this.action = action;
        }
        public void Write(T data) {
            action(data);
        }
        public void Finish() {
        }
    }
}