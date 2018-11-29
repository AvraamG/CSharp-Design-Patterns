using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryPattern.Creator;
using FactoryPattern.Product;
public class OrangeJuiceCreator : AbstractCreator
{
    int defaultPrice;
    public override AbstractProduct CreateProduct()
    {
        return new OrangeJuiceProduct(defaultPrice, "Orange Juice");
    }
}
