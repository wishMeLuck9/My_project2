using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float StartDelay = 2;
    private float SpawnInterval = 1.5f;

    void Start()
    {
        // Spawn animals again and again after a short delay.
        InvokeRepeating("SpawnRandomAnimal", StartDelay, SpawnInterval);
    }

    void SpawnRandomAnimal()
    {
        // Pick a random animal and a random spawn position.
        Vector3 SpawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Create the new animal in the scene.
        Instantiate(animalPrefabs[animalIndex], SpawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
