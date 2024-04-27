using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    public GameObject VFXPrefab;
    public GameObject collisionVFXPrefab; // Effet visuel à activer lors de la collision

    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Instancie l'effet visuel (VFX) à la position de la collision
        GameObject collisionVFX = Instantiate(collisionVFXPrefab, collision.contacts[0].point, Quaternion.identity);

        // Active l'effet visuel (VFX) de collision
        collisionVFX.SetActive(true);

        // Détruit l'effet visuel (VFX) de collision après un certain délai
        Destroy(collisionVFX, 2f);

        // Vérifie si l'objet en collision a le tag "Cible"
        if (collision.gameObject.CompareTag("Cible"))
        {
            // Détruit l'objet en collision
            Destroy(collision.gameObject);
        }

        // Détruit l'objet auquel ce script est attaché
        Destroy(gameObject);
    }
}
