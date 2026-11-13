using Unity.VisualScripting;
using UnityEngine;

public class SpawnerPowerUp : MonoBehaviour
{
    [SerializeField] int dropChance;
    [SerializeField] GameObject powerUp;

    void OnDestroy()
    {
        int temp = Random.Range(0,100);
        if(temp < dropChance)
        {
            Instantiate(powerUp, transform.position, Quaternion.identity);
        }
    }
}
