using UnityEngine;

public class Explosions : MonoBehaviour
{
    [SerializeField] float tiempoDeVida = 1f;

    void Start()
    {
        Destroy(gameObject, tiempoDeVida);
    }
}
