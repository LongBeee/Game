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
        this.transform.Translate(Vector3.left * 3 * Time.deltaTime); // ���� �������� ���� �� ���

        Destroy(gameObject, 5.0f);

    }
}
