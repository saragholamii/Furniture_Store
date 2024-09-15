using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItem : MonoBehaviour
{
    public int type;
    public int price;
    public string picturePath;
    public bool isBought = false;   

    public void SetData(MenuItem data)
    {
        type = data.type;
        price = data.price;
        picturePath = data.picturePath;
    }

}
