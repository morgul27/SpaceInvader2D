using UnityEngine;

public class Parallax : MonoBehaviour
{

    [SerializeField] Renderer rend; //referencia al MeshRenderer
    [SerializeField] float parallaxVelocity; //velocidad que le doy al parallax
    float parallaxSpeed; //movimiento del parallax

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Aumento una variable con el tiempo y multiplico por la velocidad
        parallaxSpeed += Time.deltaTime * parallaxVelocity;
        //Y se lo aplico al offset del mateial que tienen los quad
        rend.material.mainTextureOffset = new Vector2(0, parallaxSpeed);
    }
}
