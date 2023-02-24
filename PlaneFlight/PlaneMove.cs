using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    public float fRow = 0;
    public float fCol = 0;

    public float fSideSpeed = 0;
    public float fColSpeed = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fRow = Input.GetAxis("Horizontal");
        fCol = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * fRow * fSideSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * fCol * fColSpeed * Time.deltaTime);
    }
}
