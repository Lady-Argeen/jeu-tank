using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    public GameObject VFXPrefab;
    public GameObject collisionVFXPrefab; // Effet visuel � activer lors de la collision

    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Instancie l'effet visuel (VFX) � la position de la collision
        GameObject collisionVFX = Instantiate(collisionVFXPrefab, collision.contacts[0].point, Quaternion.identity);

        // Active l'effet visuel (VFX) de collision
        collisionVFX.SetActive(true);

        // D�truit l'effet visuel (VFX) de collision apr�s un certain d�lai
        Destroy(collisionVFX, 2f);

        // V�rifie si l'objet en collision a le tag "Cible"
        if (collision.gameObject.CompareTag("Cible"))
        {
            // D�truit l'objet en collision
            Destroy(collision.gameObject);
        }

        // D�truit l'objet auquel ce script est attach�
        Destroy(gameObject);
    }
}
