using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    [SerializeField]
    private float spawnTime;

    // Update is called once per frame
    private void Update()
    {
        spawnTime -= Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnTime <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawnTime = 3;
        }
    }
}