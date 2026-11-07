using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] objectsToSpawner;
    [SerializeField] float initialTime;
    [SerializeField] float spawnerTimeMin, spawnerTimeMax;

    void Start()
    {
        Invoke("SpawnObject", initialTime);
    }

    void SpawnObject()
    {
        int temp = Random.Range(0, objectsToSpawner.Length);
        Instantiate(objectsToSpawner[temp],
            transform.position, Quaternion.identity);

        float tempTime =
            Random.Range(spawnerTimeMin, spawnerTimeMax);
        Invoke("SpawnObject", tempTime);
    }



}
