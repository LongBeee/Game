using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public GameObject Enemy;
    float time = 0;

    void Start()
    {
     
    }

    void Update()
    {
        float EnemyPos_x = Random.Range(-5.0f, 5.0f);

        var po = new Vector3(EnemyPos_x, transform.position.y, transform.position.z);

        time += Time.deltaTime;
         
        if (time > 2.0f)
        {
            Instantiate(Enemy, po, Enemy.transform.rotation);
            time = 0;
        }
    }
}
