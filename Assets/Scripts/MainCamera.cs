using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    public Rigidbody sphere;
    public Camera camera;

    public Vector3 specialPosition;


    public float smoothSpeed = 0.125f;

    // Update is called once per frame
    void LateUpdate()
    {

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Vector3 targetPosition = specialPosition;
        //    Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        //    Quaternion targetRotation = Quaternion.Euler(20, Time.deltaTime *90f,0);
        //    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smoothSpeed);

        //    transform.position = smoothPosition;
        //}
        //else
        //{

            Vector3 targetPosition = target.position + offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);

            transform.position = smoothPosition;
     //   }



    }

    private void Update()
    {
        var speed = sphere.velocity.magnitude;


        var targetViewSize = 30f + (speed*8f);

        camera.fieldOfView  = Mathf.Lerp(
            30f,
            targetViewSize,
            smoothSpeed);

    }
}
