using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject smallExplotion, bigExplosion;
    public int enemyScoreValue = 5;
    public int life = 2;
    [SerializeField] AudioClip smallExplosionSound, bigExplosionSound;

   

    public void QuitarVida()
    {
        life -= 1;
        if (life > 0)
        {
            if (smallExplotion != null)
            {
                Instantiate(smallExplotion, transform.position +
                    new Vector3(0, 0, -0.1f), Quaternion.identity);
            }
            FXManager.fxManagerInstance.PlaySound(smallExplosionSound);
        } else if (bigExplosion != null)
        {
            Instantiate(bigExplosion, transform.position, Quaternion.identity);
            ScoreManager.scoreManagerInstance.AddScore(enemyScoreValue);
            FXManager.fxManagerInstance.PlaySound(bigExplosionSound);
            Destroy(gameObject);
        }
        

    }

    
}
