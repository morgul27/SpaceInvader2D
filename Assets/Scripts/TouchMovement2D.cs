using UnityEngine;

public class TouchMovement2D : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Camera cam;
    private Vector2 targetPosition;
    private bool touching;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began ||
                touch.phase == TouchPhase.Moved ||
                touch.phase == TouchPhase.Stationary)
            {
                targetPosition = cam.ScreenToWorldPoint(touch.position);
                touching = true;
            }
            else
            {
                touching = false;
            }
        }
        else
        {
            touching = false;
        }
    }

    void FixedUpdate()
    {
        if (!touching) return;

        Vector2 newPosition = Vector2.MoveTowards(
            rb.position,
            targetPosition,
            speed * Time.fixedDeltaTime
        );

        rb.MovePosition(newPosition);
    }
}
