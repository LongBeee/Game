using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCntl : MonoBehaviour
{
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
        Vector3 startPos, endPos;
    void Update()
    {
        ///*
        if(Input.GetMouseButtonDown(0))  // 0�̸� ���� Ŭ��, 1�̸� ������ Ŭ��, 2�� ��� 
        {
            startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            float len = endPos.x - startPos.x;
            speed = len/2;
        }
        //*/


        transform.Translate(speed * Time.deltaTime, 0, 0);
        //speed *= 0.98f;
    }
    private void OnBecameInvisible()
    {
        print("Out");
        Debug.Break();
    }
}
