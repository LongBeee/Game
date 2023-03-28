using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagDollEx : MonoBehaviour
{
    Rigidbody[] rBody;
    Animation anim;

    void Start()
    {
        anim = GetComponent<Animation>();
        rBody = GetComponents<Rigidbody>();
        SetRagdoll(false);
        StartCoroutine(WakeUpRagDoll());
    }

    IEnumerator WakeUpRagDoll()
    {
        yield return new WaitForSeconds(3.0f);
        SetRagdoll(true);
        anim.Stop();
    }

    private void SetRagdoll(bool isEnabled)
    {
        foreach(Rigidbody _rBody in rBody)
        {
            _rBody.isKinematic = !isEnabled;
        }
    }

    void Update()
    {
        
    }
}
