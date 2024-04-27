using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSTank : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.AddForce(bulletSpawnPoint.forward * 10f, ForceMode.Impulse);
        Destroy(bullet, 2f);

    }
}
