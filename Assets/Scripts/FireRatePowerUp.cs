using UnityEngine;

public class FireRatePowerUp : MonoBehaviour
{
    [SerializeField] float mejoraCadencia = 0.2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            PlayerShoot playerShoot = collision.GetComponent<PlayerShoot>();

            if (playerShoot != null)
            {
                playerShoot.AumentarVelocidadDisparo(mejoraCadencia);
                Destroy(gameObject);
            }
        }
    }
}
