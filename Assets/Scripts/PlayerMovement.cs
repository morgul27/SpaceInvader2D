using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector2 movement;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movement = new Vector2(x, y).normalized;
    }

    void FixedUpdate() //el update registra el boton y el fixed lo hace, por lo que el update realiza en el siguiente frame luego de registrarlo
    {
        rb.linearVelocity = movement * speed;
    }
}