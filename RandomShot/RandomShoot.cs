using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attached - ÷�ε�
// assigned - �Ҵ��

public class RandomShoot : MonoBehaviour
{
    public GameObject bullet;
    GameObject[] obj;
    Transform Po;

    void Start()
    {
        obj = GameObject.FindGameObjectsWithTag("Tower");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int i = Random.Range(0, obj.Length);
            Po = obj[i].transform.GetChild(1);
            Instantiate(bullet, Po.position, Po.rotation);
        }
    }
}