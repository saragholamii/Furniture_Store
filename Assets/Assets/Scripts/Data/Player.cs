using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private Wallet wallet = new Wallet();
    private List<Furniture> furnitureList = new List<Furniture>(); 

    public void SetData(Player data)
    {
        wallet.SetData(data.wallet);
        furnitureList.Clear();
        foreach (Furniture furnitureData in data.furnitureList)
        {
            Furniture furniture = new Furniture();
            furniture.SetData(furnitureData);
            furnitureList.Add(furniture);
        }
    }
}
