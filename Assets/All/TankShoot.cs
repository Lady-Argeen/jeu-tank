using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public GameObject VFX;
    public GameObject VFXPrefab;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            GameObject VFX = Instantiate(VFXPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            // Active l'effet visuel (VFX)
            VFX.SetActive(true);

            // Détruit l'effet visuel (VFX) après 2 secondes
            Destroy(VFX, 2f);

        }
    }




    
}