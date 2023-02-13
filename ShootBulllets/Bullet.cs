using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject obj;
    public float yPower = 400;                        // 총알을 찬 힘
    public float zPower = 200;
    //public Vector3 Velocity = new Vector3(0.5f, 0.5f,0.0f); // 총알의 속도 

    // Start is called before the first frame update
    void Start()
    {
        // Velocity *= Power;
        GetComponent<Rigidbody>().AddRelativeForce(new Vector3(5.0f, yPower, zPower), (ForceMode.Force));
        // Rigidbody - 강체(물리학 - 형체가 변하지 않는 물체)
        // AddRelativeForce - 로컬좌표로 돈다(플레이어가 원하는 위치의 기준점을 정하게 하는 함수)

    }


    // Update is called once per frame
    void FixedUpdate()          // Rigid Body - 컴포넌트 사용 시 FixedUpdate사용 - 정해진 시간
    {
        //if(Input.GetButtonDown("Fire1"))
        //{
        //    // GetComponent<Rigidbody>().AddForce(new Vector3(0.0f,yPower,zPower ),(ForceMode.Force));
        //    GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 0); // 1초에 7미터
        //}

        Destroy(gameObject, 3.0f);
        
    }
}
