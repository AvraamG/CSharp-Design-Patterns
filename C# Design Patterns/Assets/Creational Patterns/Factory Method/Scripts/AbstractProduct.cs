using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryPattern.Product
{
    public abstract class AbstractProduct : MonoBehaviour
    {
        private int defaultprice = 2;


        private static int counter;
        private int _ID;
        private int _price;
        private string _description;

        public int Price
        {
            get
            {
                return _price;
            }


        }

        public string Description
        {
            get
            {
                return _description;
            }


        }

        public int ID
        {
            get
            {
                return _ID;
            }


        }

        protected AbstractProduct(int? price, string description)
        {

            this._ID = counter;
            this._price = price ?? defaultprice;
            this._description = description;
            counter++;
        }

        public void SetDescription(string description)
        {
            this._description = description;
        }
    }
}

