using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryPattern.Product;

public class MilkProduct : AbstractProduct
{


    public MilkProduct(int? price, string description) : base(price, description)
    {
    }

}
