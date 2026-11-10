using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;

    [SerializeField] Vector2 movement;
    private float minX, maxX, minY, maxY;

    void Start()
    {
        Camera mainCamera = Camera.main;

        float screenHeight = mainCamera.orthographicSize;
        float screenWidth = screenHeight * mainCamera.aspect;

        float marginX = 0.15f;
        float marginY = 0.5f;

        minX = -screenWidth + marginX;
        maxX = screenWidth - marginX;
        minY = -screenHeight + marginY;
        maxY = screenHeight - marginY;
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movement = new Vector2(x, y).normalized;
        //animator.SetFloat("Horizontal", movement.x);
        //animator.SetFloat("Vertical", movement.y);
        //animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate() //el update registra el boton y el fixed lo hace, por lo que el update realiza en el siguiente frame luego de registrarlo
    {
        rb.linearVelocity = movement * speed;

        float clampedX = Mathf.Clamp(rb.position.x, minX, maxX);
        float clampedY = Mathf.Clamp(rb.position.y, minY, maxY);

        rb.position = new Vector2(clampedX, clampedY);
    }
}