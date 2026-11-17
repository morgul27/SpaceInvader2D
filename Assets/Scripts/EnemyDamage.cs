using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            
            GameManager.gameManagerInstance.PlayerLoseLifes();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
