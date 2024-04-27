using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private Transform t;
    private float x;

    [SerializeField] private float speed = 10;
    [SerializeField] private Vector3 direction = new Vector3(0, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
        x = t.position.x;
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("Update Delta time : " + Time.deltaTime);
        Debug.Log("Transform : " + t);
        t.position = t.position + direction * speed * Time.deltaTime;

    }

}