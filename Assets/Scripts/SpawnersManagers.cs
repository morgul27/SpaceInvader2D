using UnityEngine;

public class SpawnersManagers : MonoBehaviour
{
    public static SpawnersManagers spawnersManagersInstance;

    public Transform[] nodos; //Los nodos del camino
    public Transform[] nodos2;
    public Transform[] nodos3;

    [SerializeField] GameObject[] enemies;
    [SerializeField] Transform[] spawnerPositions;

    [SerializeField] float enemyDelay;
    [SerializeField] float counterTime;
    int position;


    private void Awake()
    {
        spawnersManagersInstance = this;
    }

    private void Update()
    {
        counterTime = counterTime + Time.deltaTime;
        position = Random.Range(0, 2);

        if (counterTime >= enemyDelay)
        {
            Instantiate(enemies[0], spawnerPositions[0].position, Quaternion.identity);
            counterTime = 0;
        }
    }
}
