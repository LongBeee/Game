using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class arrAnim
{
    public AnimationClip idle;
    public AnimationClip runForward;
    public AnimationClip runBackward;
    public AnimationClip runRight;
    public AnimationClip runLeft;
}


public class LegacyAnimationEx : MonoBehaviour
{
    float h = 0.0f, v = 0.0f;

    public float movSpeed = 5f;
    public float rotSpeed = 180f;

    public arrAnim arranim;

    Animation anim;
    Transform tr;

    void Start()
    {
        anim = GetComponent<Animation>();
        anim.clip = arranim.idle;
        anim.Play();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");

        Vector3 movDir = (Vector3.forward * v) + (Vector3.right * h);

        tr.Translate(movDir * movSpeed * v * Time.deltaTime);
        tr.Rotate(Vector3.up * rotSpeed * h * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.CrossFade(arranim.runForward.name, 0.3f);

        }
    }
}
