using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            enemy.life -= 1;
            if(enemy.life <= 0)
            {
                enemy.Morir();
            }
            Destroy(gameObject);
        }
    }
}
