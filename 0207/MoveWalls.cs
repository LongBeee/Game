using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWalls : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * 3 * Time.deltaTime); // 벽을 왼쪽으로 가게 할 명령

        Destroy(gameObject, 5.0f);

    }
}
