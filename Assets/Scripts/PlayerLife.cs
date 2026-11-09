using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public static PlayerLife playerLifeInstance;
    public int life = 3;

    private void Awake()
    {
        playerLifeInstance = this;
    }

    public void ComprobarVida()
    {
        if(life < 1)
        {
            Debug.Log("Se murio");
        }
    }
}
