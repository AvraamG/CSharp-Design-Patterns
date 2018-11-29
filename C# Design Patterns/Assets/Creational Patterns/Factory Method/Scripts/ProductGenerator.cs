using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FactoryPattern.Creator;
using FactoryPattern.Product;

public class ProductGenerator : MonoBehaviour
{

    AbstractCreator[] productConstructors = new AbstractCreator[2];
    public List<AbstractProduct> products = new List<AbstractProduct>();
    private void Start()
    {
        productConstructors[0] = new MilkCreator();
        productConstructors[1] = new OrangeJuiceCreator();
        products.Add(productConstructors[0].CreateProduct());
        products.Add(productConstructors[1].CreateProduct());

        for (int i = 0; i < products.Count; i++)
        {
            Debug.LogFormat("Product ID is {0}  product price is {1} product description is {2}", products[i].ID, products[i].Price, products[i].Description);
        }
    }

}
