using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEx : MonoBehaviour
{
    // Transform box;
    // Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float timer = 0, delayTime = 0;
    bool delay = false;
    public float delayDuringTime = 2;
    // Update is called once per frame
    void Update()
    {
        // timer += Time.deltaTime;
        // 
        // transform.rotation = Quaternion.Euler(new Vector3(0.0f, ((Mathf.Cos(timer) + 1f) * 0.5f) * 360f , 0.0f));

        delayTime += Time.deltaTime;

        if(delayTime > delayDuringTime)
        {
            delay = false;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            transform.rotation = Quaternion.Euler(0f, 100.0f, 0.0f);
            delay = true;
            delayTime = 0.0f;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            transform.eulerAngles = new Vector3(0.0f,50.0f,0.0f);
            delay = true;
            delayTime = 0.0f;
        }

        if(delay == false)
        {
            timer += Time.deltaTime;
            transform.rotation = Quaternion.Euler(new Vector3(0.0f, ((Mathf.Cos(timer) + 1f) * 0.5f) * 360f, 0.0f));
            delayTime = 0.0f;
        }
       // else if (Input.GetKeyDown(KeyCode.J))
       // {
       //     transform.rotation = Quaternion.Euler(0f, 100.0f, 0.0f);
       // }
    }
}
