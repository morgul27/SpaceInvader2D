using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject efectoExplosionPrefab;
    public int point = 5;
    public int life = 2;

    public void TomarDaño(int cantidad)
    {
        Morir();
    }

    public void Morir()
    {
        if (efectoExplosionPrefab != null)
        {
            Instantiate(efectoExplosionPrefab, transform.position, Quaternion.identity);
        }
        ScoreManager.scoreManagerInstance.AddScore(point);
        Destroy(gameObject);
    }
}
