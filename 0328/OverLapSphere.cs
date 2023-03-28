using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverLapSphere : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // 폭탄 효과 - 다른 오브젝트들이 리지드 바디를 가지고 있을 시 
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
