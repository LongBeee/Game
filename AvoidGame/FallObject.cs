using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class FallObject : MonoBehaviour
{
    public GameObject Meteor;
    Vector3[] Pos = new Vector3[10];
    //GameObject[] Meteor; // ���׿�
    //Transform[] Sky;

    //public float xPos = 0;
    //public float yPos = 0;
    //public float zPos = 0;



    void Start()
    {
        //Meteor = GameObject.FindGameObjectsWithTag("Sky");

        // GetComponent<Rigidbody>().AddRelativeForce(new Vector3(xPos, yPos , zPos), (ForceMode.Force));
        // AddRelativeForce - ������ǥ�� ����(�÷��̾ ���ϴ� ��ġ�� �������� ���ϰ� �ϴ� �Լ�)
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
            iObj.transform.localPosition = new Vector3(Random.Range(-25, 24), 30, Random.Range(-25,24)); // ���׿� ����

            iObj.AddComponent<Rigidbody>();                                 // ������Ʈ �߰�
            iObj.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);      // ũ��
            iObj.GetComponent<MeshRenderer>().material.color = Color.black; // ��ü ��

            //iObj.transform.position = Pos[Random.Range(0, 10)];
            //GameObject Obj = Instantiate(Meteor, Pos[Random.Range(0, 10)],Quaternion.identity);

            Destroy(iObj, 3.0f);
            DTime = 0;
        }

    }
}
