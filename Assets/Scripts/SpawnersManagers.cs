using UnityEngine;

public class SpawnersManagers : MonoBehaviour
{
    public static SpawnersManagers spawnersManagersInstance;


    [Header("Los caminos")]
    public Transform[] nodos1, nodos2, nodos3; //Los nodos del camino

    [SerializeField] GameObject[] enemies;
    [SerializeField] Transform[] spawnerPositions;

    [SerializeField] float enemyDelay;
    [SerializeField] float counterTime;

    [Header ("Datos de la ola")]
    public int currentWave; //Ola actual en la que estamos
    [SerializeField] int[] enemiesWavesCounter; //enemigos creados en esa ola
    [SerializeField] int[] enemiesWavesTotal; //cuantos enemigos hay en esta ola

    //Toolkit, en vez de header y sirve para explicar que hace las variables

    private void Awake()
    {
        spawnersManagersInstance = this;
    }

    private void Update()
    {
        counterTime = counterTime + Time.deltaTime;

        if (counterTime >= enemyDelay)
        {
            Instantiate(enemies[0], spawnerPositions[currentWave].position, Quaternion.identity);
            counterTime = 0;

            enemiesWavesCounter[currentWave]++;
            if (enemiesWavesCounter[currentWave] >= enemiesWavesTotal[currentWave])
            {
                currentWave++;
            }
            
        }
    }
}
