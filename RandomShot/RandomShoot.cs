using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attached - 첨부된
// assigned - 할당된

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