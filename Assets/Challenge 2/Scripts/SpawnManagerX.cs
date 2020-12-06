using System.Collections;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float spawnInterval = 5.0f;
    public float spawnTimeMIN = 3.0f;
    public float spawnTimeMAX = 5.0f;
    private bool canSpawn = true;

    private void Update()
    {
        if (canSpawn)
        {
            StartCoroutine(nameof(SpawnRandomBall));
            canSpawn = false;
        }
    }

    // Spawn random ball at random x position at top of play area
    private IEnumerator SpawnRandomBall()
    {
        spawnInterval = Random.Range(spawnTimeMIN, spawnTimeMAX);

        yield return new WaitForSeconds(spawnInterval);

        canSpawn = true;
        // Generate random ball index and random spawn position
        var spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        var ballIndex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}