using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryPattern.Creator;
using FactoryPattern.Product;

public class OrangeJuiceProduct : AbstractProduct
{
    public OrangeJuiceProduct(int? price, string description) : base(price, description)
    {
    }
}
