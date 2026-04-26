using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public GameObject triggerPrefab;
    [SerializeField] private ScoreManager playerScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPipes",0.0f, 2.0f);
    }
    
    private void OnEnable()
    {
        if (playerScore != null)
            playerScore.OnChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        if (playerScore != null)
            playerScore.OnChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int newScore)
    {
        Debug.Log("Новый счёт: " + newScore);
    }
    
    
    void SpawnPipes()
    {
        float randPozTop = Random.Range(0.0f, 10.0f);
        //playerScore.Add();
        Instantiate(triggerPrefab, new Vector3(transform.position.x + 1.0f, transform.position.y + randPozTop - 5.0f, transform.position.z), Quaternion.identity);
        Instantiate(pipePrefab, new Vector3(transform.position.x, transform.position.y + 5.0f + randPozTop, transform.position.z), Quaternion.identity);
        Instantiate(pipePrefab,
            new Vector3(transform.position.x, transform.position.y - 5.0f - (10.0f - randPozTop), transform.position.z),
            Quaternion.identity);
    }
}
