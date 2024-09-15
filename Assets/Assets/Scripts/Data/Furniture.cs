using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture
{
    public int type;
    public int price;

    public void SetData(Furniture data)
    {
        type = data.type;
        price = data.price;
    }
}
