using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    //Riggibody2D

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    //en el void start
    //rb2D.linearValocity = bulletDirectionm * bulletSpeed;

}
