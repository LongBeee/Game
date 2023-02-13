using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw2 : MonoBehaviour
{
    public float xSpeed = 400.0f;
    public float ySpeed = 400.0f;
    void Start()
    {
        Rigidbody rig = GetComponent<Rigidbody>();

        rig.velocity = new Vector3(7, 12, 0);
        rig.useGravity = true;
    }

    float duringTime = 0.0f;
    void Update()
    {
        duringTime += Time.deltaTime;

        if(duringTime > 2)
        {
            Destroy(gameObject);
        }

        Destroy(gameObject,3.0f);
    }
}
