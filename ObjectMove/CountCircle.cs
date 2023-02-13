using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCircle : MonoBehaviour
{
    GameObject[] obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectsWithTag("Circle");
        print(obj.Length);
        
        foreach(var actor in obj)
        {
            Transform trActor = actor.GetComponent<Transform>();  // ����Ƽ ������ ������Ʈ�� �ҷ��´�. - GetComponent<>

            print(actor.name+ "�� x�� :" + actor.GetComponent<Transform>().position.x);

            trActor.position = new Vector3(trActor.position.x + 2, trActor.position.y, trActor.position.z); // trActor.position. () �� transform ������Ʈ�� �⺻ ���� ������ �ȴ�.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
