using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class FallObject : MonoBehaviour
{
    public GameObject Meteor;
    Vector3[] Pos = new Vector3[10];
    //GameObject[] Meteor; // 메테오
    //Transform[] Sky;

    //public float xPos = 0;
    //public float yPos = 0;
    //public float zPos = 0;



    void Start()
    {
        //Meteor = GameObject.FindGameObjectsWithTag("Sky");

        // GetComponent<Rigidbody>().AddRelativeForce(new Vector3(xPos, yPos , zPos), (ForceMode.Force));
        // AddRelativeForce - 로컬좌표로 돈다(플레이어가 원하는 위치의 기준점을 정하게 하는 함수)
        for(int i = 0; i < Pos.Length; i++)
        {
            Pos[i] = new Vector3(Random.Range(-5, 6), 7, Random.Range(-5, 6));
        }
    }

    public float MeteorPos;
    float DTime = 0.0f;
    float DelayTime = 0.0f;
    void Update()
    {
        //int Count = Random.Range(-5, 5);
        //Sky = Meteor[Count].transform.GetChild(1);
        //Instantiate(obj, Sky.position, Sky.rotation);
        //Thread.Sleep(500);
        DTime += Time.deltaTime;

        if (DTime > 0.8f)
        {
            GameObject iObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            iObj.transform.localPosition = new Vector3(Random.Range(-25, 24), 30, Random.Range(-25,24)); // 메테오 랜덤

            iObj.AddComponent<Rigidbody>();                                 // 컴포넌트 추가
            iObj.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);      // 크기
            iObj.GetComponent<MeshRenderer>().material.color = Color.black; // 물체 색

            //iObj.transform.position = Pos[Random.Range(0, 10)];
            //GameObject Obj = Instantiate(Meteor, Pos[Random.Range(0, 10)],Quaternion.identity);

            Destroy(iObj, 3.0f);
            DTime = 0;
        }

    }
}
