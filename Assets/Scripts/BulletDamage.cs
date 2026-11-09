using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            EnemyPoint enemy = collision.gameObject.GetComponent<EnemyPoint>();

            Destroy(collision.gameObject);
            ScoreManager.scoreManagerInstance.AddScore(enemy.point);
            Destroy(gameObject);
        }
    }
}
