using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverLapSphere : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // ��ź ȿ�� - �ٸ� ������Ʈ���� ������ �ٵ� ������ ���� �� 
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Collider[] colls = Physics.OverlapSphere(transform.position, 5.0f);

            foreach(Collider col in colls)
            {
                Rigidbody rBody = col.GetComponent<Rigidbody>();

                if(rBody != null)
                {
                    rBody.isKinematic = false;
                    rBody.AddExplosionForce(1000.0f, transform.position, 5.0f, 300.0f);
                }
            }
        }
    }
}
