using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryPattern.Product;

namespace FactoryPattern.Creator
{
    public abstract class AbstractCreator : MonoBehaviour
    {
        public abstract AbstractProduct CreateProduct();
    }
}

