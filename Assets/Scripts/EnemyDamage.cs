using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            PlayerLife.playerLifeInstance.life -= 1;

            PlayerLife.playerLifeInstance.ComprobarVida();
            Destroy(gameObject);
        }
    }
}
