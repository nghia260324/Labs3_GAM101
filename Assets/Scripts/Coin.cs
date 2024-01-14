using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int minCoin;
    public int maxCoin;

    public int GetCoin()
    {
        return Random.Range(minCoin, maxCoin);
    }
}
