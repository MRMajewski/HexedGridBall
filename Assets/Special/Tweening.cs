using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweening : MonoBehaviour
{

    public GameObject[] targets;
  //  public GameObject target;
    Vector3 targetScale;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject target in targets)
        {
            targetScale = new Vector3((Mathf.PingPong(Time.time, 1) + 2), (Mathf.PingPong(Time.time, 1) + 2), (Mathf.PingPong(Time.time, 1) + 2));
            target.transform.localScale = Vector3.Lerp(target.transform.localScale, targetScale, Time.deltaTime);
        }
      
    }
}

