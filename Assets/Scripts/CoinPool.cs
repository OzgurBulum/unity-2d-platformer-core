using System.Collections.Generic;
using UnityEngine;

public class CoinPool : MonoBehaviour
{
    public GameObject coinPrefab;
    public int poolSize = 10;
    private List<GameObject> pool;

    void Start()
    {
        pool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject coin = Instantiate(coinPrefab);
            coin.SetActive(false);
            pool.Add(coin);
        }
    }

    public GameObject GetPooledCoin()
    {
        foreach (GameObject coin in pool)
        {
            if (!coin.activeInHierarchy)
            {
                return coin; 
            }
        }
        return null;
    }
}