using System.Collections.Generic;

namespace HephaestusMobile.ObjectPoolSubsystem {
    public interface IObjectPoolManager<T> {
        /// <summary>
        /// Gets or sets the objects pool.
        /// </summary>
        /// <value>The objects pool.</value>
        Queue<IPoolableObject> ObjectsPool { get; set; }

        /// <summary>
        /// Initialize this instance.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Gets the object.
        /// </summary>
        /// <returns>The object.</returns>
        T GetObject();

        /// <summary>
        /// Adds the object.
        /// </summary>
        /// <param name="poolObject">Pool object.</param>
        void AddObject(T poolObject);
    }
}
