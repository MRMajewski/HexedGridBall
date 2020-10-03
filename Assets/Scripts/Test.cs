using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public Transform Prefab;
    // Start is called before the first frame update

        [ContextMenu("TestLerp")]

    [ContextMenu("TestTranform")]
    void Start()
    {

        //Vector3 prefabSize = Prefab.GetComponent<Collider>().bounds.size;
        //Debug.Log("X " + prefabSize.x);
        //Debug.Log("Y " + prefabSize.y);
        //Debug.Log("Z " + prefabSize.z);


    }

    private void Update()
    {
        if ((Input.GetMouseButton(0))) TestLerp();
    }

    private void TestTranform()
    {
        this.transform.position = new Vector3(5, 5, 5);
    }

    private void TestLerp()
    {
        Vector3 targetPosition = new Vector3(5, 5, 5);

        this.transform.position = Vector3.Lerp(transform.position, targetPosition, Time.time*5f);
    }

    void UpdateSize()
    {

    }

}
