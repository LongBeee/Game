using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWalls : MonoBehaviour
{
    public GameObject Walls;
    float time = 0;

    void Start()
    {
        //transform.position = new Vector3(-2.7505f, -3.642178f, -1.320738f);
        //startPos.transform.position = new Vector3(-2.7505f, -3.642178f, -1.320738f);
    }

    // float Wall_x = -2.7505f;
    // float Wall_y = -3.642178f;

    //bool ColisionWall = false;

    void Update()
    {
        // transform.position = new Vector3(Wall_x, Wall_y, transform.position.z);
        // 
        // Wall_x += 0.75f;
        // Wall_y += 1.0f;


        // 벽이 생성되게
        int WallPos = Random.Range(-3, 3);

        var po = new Vector3(Walls.transform.position.x, WallPos, Walls.transform.position.z);

        time += Time.deltaTime;
        if (time  > 2) 
        {
            Instantiate(Walls, po , Walls.transform.rotation);
            time = 0;
        }
        
    }
}
