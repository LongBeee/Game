using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBullet : MonoBehaviour
{
    public GameObject obj;
    Transform ShotPos;

    public float fBulletSpeed = 0;
    public float xSpeed = 0;
    public float ySpeed = 0;
    public float zSpeed = 0;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        ShotPos = GameObject.Find("Player").GetComponent<Transform>();

        obj.GetComponent<Rigidbody>().velocity = Vector3.forward * fBulletSpeed * Time.deltaTime;

        obj.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(xSpeed,ySpeed,zSpeed), (ForceMode.Force));
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(obj, ShotPos.position, ShotPos.rotation);
        }
        

    }
}
