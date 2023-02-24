using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    GameObject obj;
    public float yPower = 400;                      
    public float zPower = 200;
    void Start()
    {
        GetComponent<Rigidbody>().AddRelativeForce(new Vector3(5.0f, yPower, zPower), (ForceMode.Force));
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5.0f);
    }
}
