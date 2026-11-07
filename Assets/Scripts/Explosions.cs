using UnityEngine;

public class Explosions : MonoBehaviour
{
    public GameObject explosionPrefab;

    void Morir()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
