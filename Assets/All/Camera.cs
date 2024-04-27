using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {

    
    // Camera

    turn.x += Input.GetAxis("Mouse X") * sensitivity;
        //turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
public Vector2 turn;
public float sensitivity = .5f;
public Vector3 deltaMove;
public float speedCamera = 1;
void Start()
{
    Cursor.lockState = CursorLockMode.Locked;
}
    
}
