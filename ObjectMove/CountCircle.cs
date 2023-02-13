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
            Transform trActor = actor.GetComponent<Transform>();  // 유니티 엔진의 컴포넌트를 불러온다. - GetComponent<>

            print(actor.name+ "의 x값 :" + actor.GetComponent<Transform>().position.x);

            trActor.position = new Vector3(trActor.position.x + 2, trActor.position.y, trActor.position.z); // trActor.position. () 는 transform 컴포넌트의 기본 값을 넣으면 된다.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
