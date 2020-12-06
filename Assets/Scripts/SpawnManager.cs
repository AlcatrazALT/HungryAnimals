using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] animalPrefabs;

    [SerializeField]
    private float startDelay = 2;

    [SerializeField]
    private float spawnInterval = 1.5f;

    private float spawnRangeX = 10.0f;
    private float spawnPositionZ = 20.0f;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimals), startDelay, spawnInterval);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void SpawnRandomAnimals()
    {
        var animalIndex = Random.Range(0, animalPrefabs.Length);

        var spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}