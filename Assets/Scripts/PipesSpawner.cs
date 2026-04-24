using UnityEngine;

public class PipesSpawner : MonoBehaviour
{

    public GameObject pipePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPipes", 0.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipes()
    {
        float randPozTop = Random.Range(0.0f, 10.0f);

        Instantiate(pipePrefab, new Vector3(transform.position.x, transform.position.y + 5.0f + randPozTop, transform.position.z), Quaternion.identity);
        Instantiate(pipePrefab, new Vector3(transform.position.x, transform.position.y - 5.0f - (10.0f - randPozTop), transform.position.z), Quaternion.identity);
    }
}
