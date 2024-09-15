using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet
{
    public int coins = 0;

    public void AddCoins(int amount)
    {
        coins += amount;
    }   

    public void RemoveCoins(int amount)
    {
        coins -= amount;
    }

    public void SetData(Wallet data)
    {
        coins = data.coins;
    }

}
