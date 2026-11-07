using UnityEngine;

public class AutoDestruction : MonoBehaviour
{
    [SerializeField] float destructionTime;

    void Start()
    {
        Destroy(gameObject, destructionTime);
    }

}
