using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public CoinPool coinPool;
    public float spawnInterval = 2f;
    private float coinLifetime = 3f;

    void Start()
    {
        InvokeRepeating("SpawnCoin", 0f, spawnInterval);
    }

    void SpawnCoin()
    {
        GameObject coin = coinPool.GetPooledCoin();

        if (coin != null)
        {
            coin.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-3f, 3f), 0f);
            coin.SetActive(true);
            StartCoroutine(DeactivateCoinAfterTime(coin));
        }
    }

    System.Collections.IEnumerator DeactivateCoinAfterTime(GameObject coin)
    {
        yield return new WaitForSeconds(coinLifetime);
        coin.SetActive(false);
    }

}
