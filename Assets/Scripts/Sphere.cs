using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody rigidbody;

    void Update()
    {
        UpdateMovement();
     
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "lava")
        {

            transform.position = new Vector3(-0.54f, 12.75f, -8.8f);
            rigidbody.velocity = Vector3.zero;
        }          
    }

    private void UpdateMovement()
    {
        var direction = Vector3.zero; // zmienna z kierunkiem

        if (Input.GetKey(KeyCode.UpArrow))
            direction += Vector3.forward;

        if (Input.GetKey(KeyCode.DownArrow))
            direction += Vector3.back;

        if (Input.GetKey(KeyCode.LeftArrow))
            direction += Vector3.left;

        if (Input.GetKey(KeyCode.RightArrow))
            direction += Vector3.right;

        rigidbody.AddTorque(direction * speed);
    }
}
