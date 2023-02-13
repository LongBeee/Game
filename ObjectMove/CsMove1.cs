using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsMove1 : MonoBehaviour
{
    float movSpeed = 20.0f;
    float rotSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float   v = Input.GetAxis("Vertical");      // -1 ~ +1 : ���� ���� 0�� ������
        float ang = Input.GetAxis("Horizontal");    // -1 ~ +1 : ���� ���� 0�� ������
        //float h = Input.GetAxis("Horizontal");

        print("v Value : " + v);

        transform.Rotate(Vector3.up * rotSpeed * movSpeed * Time.deltaTime * ang);
        transform.Translate(Vector3.forward    * movSpeed * Time.deltaTime * v);
        //transform.Translate(Vector3.right    * speed * Time.deltaTime * h);

        if(Input.GetButtonDown("Jump"))  
        {
            print("Fire1");
            transform.rotation = Quaternion.identity;        // - World ��ǥ�Կ� ����
            // transform.localRotation = Quaternion.identity;   - �θ� �������� �Ѵ�. 
        }

    }
}
