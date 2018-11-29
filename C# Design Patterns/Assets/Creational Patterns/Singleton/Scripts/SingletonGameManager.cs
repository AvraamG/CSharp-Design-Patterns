using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Singleton.Example
{
    public class SingletonGameManager : MonoBehaviour
    {
        private static SingletonGameManager _instance;
        public static SingletonGameManager Instance
        {
            get
            {
                return _instance;
            }
        }

        private void Awake()
        {
            InitializeSingleton();
        }

        /// <summary>
        /// if the private static variable of the instance is not assigned, assign it to this script. Otherwise take care of it, destroy/deactivate etc.
        /// </summary>
        private void InitializeSingleton()
        {
            if (_instance == null)
            {
                _instance = this;
                Debug.LogFormat("Initialized Singleton to {0}", this.gameObject.name);
            }
            else
            {
                Debug.LogErrorFormat("More than 1 Singleton GameManagers in the scene destroyed the duplicate {0}", this.gameObject.name);
                Destroy(this.gameObject);
            }
        }
        /// <summary>
        /// Hello world public method so other classes can access it through the public static SingletonGameManager.Instance.
        /// </summary>
        public void SayHello()
        {
            Debug.LogFormat("Hello from {0}", this.gameObject.name);
        }


    }
}

