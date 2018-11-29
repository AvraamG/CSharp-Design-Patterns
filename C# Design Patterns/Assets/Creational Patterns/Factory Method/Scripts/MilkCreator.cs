using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryPattern.Creator;
using FactoryPattern.Product;

public class MilkCreator : AbstractCreator
{
    public override AbstractProduct CreateProduct()
    {
        return new MilkProduct(5, "Just Milk");
    }
}
