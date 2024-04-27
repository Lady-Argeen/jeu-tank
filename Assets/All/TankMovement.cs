using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f; // Vitesse de rotation
    public Animator tankAnimator; // R�f�rence � l'animator du tank
    private bool isMoving = false; // Indique si le tank est en mouvement

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");



        // Translation du tank
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);

        // Rotation du tank
        if (horizontalInput != 0) // Si les touches Q ou D sont utilis�es
        {
            float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, rotationAmount);
        }

        // Active l'animation "Wheel" si le tank commence � se d�placer
        if (!isMoving && (horizontalInput != 0 || verticalInput != 0))
        {
            isMoving = true;
            tankAnimator.SetBool("IsMoving", true);
        }
        else if (isMoving && horizontalInput == 0 && verticalInput == 0)
        {
            isMoving = false;
            tankAnimator.SetBool("IsMoving", false);
        }
    }
}

