using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCible : MonoBehaviour
{
    public GameObject activationObject; // GameObject à activer si aucun objet avec le tag "Cible" n'est présent
    public string targetTag = "Cible"; // Tag des objets cibles

    void Update()
    {
        // Vérifie s'il ne reste aucun objet avec le tag "Cible" dans la scène
        if (!CheckIfTargetsExist())
        {
            // Active le GameObject
            activationObject.SetActive(true);
        }
    }

    bool CheckIfTargetsExist()
    {
        // Récupère tous les objets avec le tag "Cible" dans la scène
        GameObject[] targets = GameObject.FindGameObjectsWithTag(targetTag);

        // Retourne true s'il reste des objets avec le tag "Cible" dans la scène, sinon false
        return targets.Length > 0;
    }
}
