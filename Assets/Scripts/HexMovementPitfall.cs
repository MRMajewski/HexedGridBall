using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMovementPitfall : MonoBehaviour
{

    private bool pitfallOn = false;
    private bool isPitfallDown = false;
    // Start is called before the first frame update

    public Vector3 downPosition = new Vector3(0, -3, 0);

    public float waitTime = 6f;

    public float speedHex = 2f;


    private void Start()
    {
        // StartCoroutine(PitfallMovementCoroutine());
      //  PitfallMovementCoroutineNew(new Vector3(transform.position.x, -5, transform.position.z),3f);
    }
    // Update is called once per frame
    void Update()
    {
        //if (pitfallOn == false) return;
        ////  StartCoroutine(PitfallMovementCoroutine());
        //waitTime -= Time.deltaTime;

        //if(waitTime<0 && isPitfallDown == false)
        //{
        //    Vector3 targetPosition = new Vector3(transform.position.x, -5, transform.position.z);

        //    this.transform.position = Vector3.Lerp(transform.position,targetPosition, Time.deltaTime * speedHex);
        //  //  waitTime = 3f;
        //    isPitfallDown = true;
        //}
        //if (waitTime < 0 && isPitfallDown == true)
        //    {
        //    Vector3 targetPosition = new Vector3(transform.position.x, 0, transform.position.z);
        //    this.transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speedHex);
        // //   waitTime = 3f;
        //    isPitfallDown = false;
        //}
        waitTime -= Time.deltaTime;

        if (waitTime < 10f)
        {
            this.transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, 10, transform.position.z), Time.deltaTime * 3f);

            if (waitTime < 5f)
            {
                this.transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, 5, transform.position.z), Time.deltaTime * 3f);
                // waitTime = 6f;
            }
            if (waitTime < 0f) waitTime = 10f;


            // this.transform.position = new Vector3(transform.position.x, 5, transform.position.z);
        }



    }


    private void OnTriggerEnter(Collider other)
    {
        pitfallOn = true;
    }

    IEnumerator PitfallMovementCoroutine()
    {
        while (true)
        {
          //  this.transform.position = new Vector3(transform.position.x, 10, transform.position.z);
            this.transform.position =  Vector3.Lerp(transform.position, new Vector3(transform.position.x, 10, transform.position.z),Time.deltaTime*5f);
            yield return new WaitForSeconds(2f);
            this.transform.position = new Vector3(transform.position.x, 5, transform.position.z);
            yield return new WaitForSeconds(2f);
        }

    }

    IEnumerator PitfallMovementCoroutineNew(Vector3 NewPosition, float time)
    {
        float elapsedTime = 0f;
        Vector3 startingPosition = this.transform.position;

        while (elapsedTime<time)
        {

            this.transform.position = Vector3.Lerp(startingPosition, new Vector3(transform.position.x, 10, transform.position.z), elapsedTime / time);
          //  this.transform.position = new Vector3(transform.position.x, 5, transform.position.z);
            yield return new WaitForSeconds(2f);
        }

    }
}
