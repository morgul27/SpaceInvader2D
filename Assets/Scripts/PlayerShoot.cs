using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;    
    [SerializeField] float fireRate;
    [SerializeField] float counter;
    [SerializeField] float tiempoPowerUp;
    [SerializeField] bool isPowerUp;
    private float nextFireTime = 0f;


    private float originalFireRate;
    private Coroutine powerUpCoroutine;


    void Start()
    {
        originalFireRate = fireRate;
    }

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }

        
        if(isPowerUp == true){
            counter = counter + Time.deltaTime;
            if(counter >= tiempoPowerUp)
            {
                isPowerUp = false;
                fireRate = originalFireRate;
            }
        }

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void AumentarVelocidadDisparo(float velocidadPowerUp)
    {
        isPowerUp = true;
        counter = 0;
        fireRate = velocidadPowerUp;

        if (fireRate < 0.005f)
        {
            fireRate = 0.005f;
        }
        
    }

}
