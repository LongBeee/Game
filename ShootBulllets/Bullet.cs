using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject obj;
    public float yPower = 400;                        // �Ѿ��� �� ��
    public float zPower = 200;
    //public Vector3 Velocity = new Vector3(0.5f, 0.5f,0.0f); // �Ѿ��� �ӵ� 

    // Start is called before the first frame update
    void Start()
    {
        // Velocity *= Power;
        GetComponent<Rigidbody>().AddRelativeForce(new Vector3(5.0f, yPower, zPower), (ForceMode.Force));
        // Rigidbody - ��ü(������ - ��ü�� ������ �ʴ� ��ü)
        // AddRelativeForce - ������ǥ�� ����(�÷��̾ ���ϴ� ��ġ�� �������� ���ϰ� �ϴ� �Լ�)

    }


    // Update is called once per frame
    void FixedUpdate()          // Rigid Body - ������Ʈ ��� �� FixedUpdate��� - ������ �ð�
    {
        //if(Input.GetButtonDown("Fire1"))
        //{
        //    // GetComponent<Rigidbody>().AddForce(new Vector3(0.0f,yPower,zPower ),(ForceMode.Force));
        //    GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 0); // 1�ʿ� 7����
        //}

        Destroy(gameObject, 3.0f);
        
    }
}
