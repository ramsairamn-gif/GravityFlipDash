using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public float spawnInterval = 1.5f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnPlatform();
            timer = 0f;
        }
    }

    void SpawnPlatform()
    {
        float yPos = Random.Range(-4f, 4f);
        Vector3 spawnPos = new Vector3(10f, yPos, 0f);
        Instantiate(platformPrefab, spawnPos, Quaternion.identity);
    }
}
