namespace ParallelPipeline.Channels {
        public interface IWritableChannel<T> {
        void Write(T data);
        void Finish();
    }
}