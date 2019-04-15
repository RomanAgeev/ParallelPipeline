namespace ParallelPipeline.Channels {
    public interface IReadableChannel<T> {
        bool Read(out T data, Profiler profiler = null);
    }
}