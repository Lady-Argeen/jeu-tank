using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCible : MonoBehaviour
{
    public GameObject activationObject; // GameObject � activer si aucun objet avec le tag "Cible" n'est pr�sent
    public string targetTag = "Cible"; // Tag des objets cibles

    void Update()
    {
        // V�rifie s'il ne reste aucun objet avec le tag "Cible" dans la sc�ne
        if (!CheckIfTargetsExist())
        {
            // Active le GameObject
            activationObject.SetActive(true);
        }
    }

    bool CheckIfTargetsExist()
    {
        // R�cup�re tous les objets avec le tag "Cible" dans la sc�ne
        GameObject[] targets = GameObject.FindGameObjectsWithTag(targetTag);

        // Retourne true s'il reste des objets avec le tag "Cible" dans la sc�ne, sinon false
        return targets.Length > 0;
    }
}
