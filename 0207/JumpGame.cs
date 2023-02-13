using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpGame : MonoBehaviour
{
    Transform Player;
    public float JumpSpeed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, JumpSpeed, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Application.LoadLevel("JumpGame");
        SceneManager.LoadScene(0);
    }
}
