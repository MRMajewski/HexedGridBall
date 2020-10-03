using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMovement : MonoBehaviour
{

    public float speed=1;
    public float distance = 2;
    public float offset = 1;

    public float speedHex = 2;

    public float passivePosition = 10f;

    

    private bool collide = false;

    Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.25f, 1.25f);
    }

    // Update is called once per frame
    void Update()
    {
        if (collide)
        {
           targetPosition = new Vector3(transform.position.x, passivePosition, transform.position.z);
            this.transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speedHex);
        }
        else


          targetPosition = new Vector3(transform.position.x, (Mathf.PingPong(Time.time * speed, distance)+offset), transform.position.z);
          this.transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speedHex);


    }

    private void OnTriggerEnter(Collider other)
    {
        collide = true;
    }

    private void OnTriggerExit(Collider other)
    {
        collide = false;
    }

}
