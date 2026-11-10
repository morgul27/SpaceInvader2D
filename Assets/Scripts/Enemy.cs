using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject smallExplotion, bigExplosion;
    public int point = 5;
    public int life = 2;
    [SerializeField] AudioClip smallExplosionSound, bigExplosionSound;

    public void TomarDaño(int cantidad)
    {
        Morir();
    }

    public void QuitarVida()
    {
        life -= 1;
        if (smallExplotion != null)
        {
            Instantiate(smallExplotion, transform.position, Quaternion.identity);
        }
        FXManager.fxManagerInstance.PlaySound(smallExplosionSound);
    }

    public void Morir()
    {
        if (bigExplosion != null)
        {
            Instantiate(bigExplosion, transform.position, Quaternion.identity);
        }
        ScoreManager.scoreManagerInstance.AddScore(point);
        FXManager.fxManagerInstance.PlaySound(bigExplosionSound);
        Destroy(gameObject);
    }

    
}
