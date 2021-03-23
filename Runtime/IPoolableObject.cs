namespace HephaestusMobile.ObjectPoolSubsystem {
    public interface IPoolableObject {
        void Activate();
        void Deactivate();
    }
}