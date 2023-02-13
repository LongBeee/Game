using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject obj;
    Transform startPos;
    float deltaZ;
    
    void Start()
    {
        startPos = GameObject.Find("Player").GetComponent<Transform>(); 
        startPos = startPos.transform.GetChild(1); // 자식 오브젝트 찾는방법 - GetChild함수
        print(startPos.name);
    }
 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //Instantiate(obj, new Vector3(startPos.position.x,startPos.position.y, deltaZ), Quaternion.identity);
            Instantiate(obj, startPos.position, startPos.rotation);
        }
       
    }
}
