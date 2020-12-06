using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40.0f;
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}