using System.Collections.Generic;

namespace HephaestusMobile.ObjectPoolSubsystem {

    public class ObjectPoolManager : IObjectPoolManager<IPoolableObject> {

        /// <inheritdoc />
        public Queue<IPoolableObject> ObjectsPool { get; set; }

        /// <inheritdoc />
        public void Initialize() {
            ObjectsPool = new Queue<IPoolableObject>();
        }

        /// <inheritdoc />
        public IPoolableObject GetObject() {
            return ObjectsPool.Dequeue();
        }

        /// <inheritdoc />
        public void AddObject(IPoolableObject poolObject) {
            ObjectsPool.Enqueue(poolObject);
        }
    }
}
