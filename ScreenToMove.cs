using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToMove : MonoBehaviour
{
    public Transform target;
    public GameObject sObj;
    //Camera camera;

    void Start()
    {
        //camera = GetComponent<Camera>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Vector3 screenPos = Camera.main.WorldToScreenPoint(target.position);
            Debug.Log("screenPos.x : " + screenPos.x);
            Debug.Log("screenPos.y : " + screenPos.y);
            Debug.Log("screenPos.z : " + screenPos.z);

            float cratePosX = Random.Range(0, Screen.width);
            //float cratePosY = Random.Range(0, Screen.height);

            Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(cratePosX, Screen.height, screenPos.z));
            GameObject obj = Instantiate(sObj);
            obj.transform.position = newPos;
        }
    }

    //void Update()
    //{
    //    if(Input.GetButtonDown("Fire2"))
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 카메라에서 마우스로 찍은 포지션의 값만큼 Ray를 나타낸다.
    //
    //        RaycastHit hit;
    //
    //        if(Physics.Raycast(ray, out hit))
    //        {
    //            Vector3 newPos = new Vector3(hit.point.x, hit.point.y, hit.point.z);
    //            transform.position = newPos;
    //        }
    //    }
    //}
}
