using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public float speed = 1;
    public float distance = 2;
    public float offset = 1;

    public float speedHex = 2;

    public float passivePosition = 10f;



    private bool collide = false;

    Vector3 targetPosition;

    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        targetPosition = new Vector3(transform.position.x, transform.position.y,(Mathf.PingPong(Time.time * speed, distance) + offset));
        this.transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speedHex);
    }

    private void OnTriggerEnter(Collider other)
    {
   //     if (other.gameObject == sphere)
            sphere.transform.parent = transform;

    }

    private void OnTriggerExit(Collider other)
    {
    //    if (other.gameObject == sphere)
            sphere.transform.parent = null;
    }
   
}
