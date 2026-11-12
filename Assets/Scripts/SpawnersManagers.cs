using UnityEngine;

public class SpawnersManagers : MonoBehaviour
{
    public static SpawnersManagers spawnersManagersInstance;

    public Transform[] nodos; //Los nodos del camino

    [SerializeField] GameObject[] enemies;
    [SerializeField] Transform[] spawnerPositions;

    [SerializeField] float enemyDelay;
    [SerializeField] float counterTime;


    private void Awake()
    {
        spawnersManagersInstance = this;
    }

    private void Update()
    {
        counterTime = counterTime + Time.deltaTime;

        if(counterTime >= enemyDelay)
        {
            Instantiate(enemies[0], spawnerPositions[0].position, Quaternion.identity);
            counterTime = 0;
        }
    }
}
