using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton.Example;
public class SingletonPlayer : MonoBehaviour
{


    void Start()
    {
        SingletonGameManager.Instance.SayHello();
    }


}
