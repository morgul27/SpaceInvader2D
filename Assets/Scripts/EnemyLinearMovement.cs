using UnityEngine;

public class EnemyLinearMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rbd2d;
    [SerializeField] Vector2 enemydireccion;
    [SerializeField] float speed;


    void Start()
    {
        rbd2d.linearVelocity = enemydireccion * speed;
    }

    
}
