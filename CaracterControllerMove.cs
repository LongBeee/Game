using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracterControllerMove : MonoBehaviour
{
    public float fMovSpeed = 5.0f;
    public float fRotSpeed = 120.0f;
    CharacterController controller;
    Vector3 moveDir;
    float fGravity = 20.0f;
    float jumpSpeed = 10.0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {

            float row = Input.GetAxis("Horizontal");
            float col = Input.GetAxis("Vertical");

            //transform.Translate(Vector3.forward * fMovSpeed * col * Time.deltaTime);
            transform.Rotate(Vector3.up * fRotSpeed * row * Time.deltaTime);
            moveDir = new Vector3(0, 0, col * fMovSpeed);
            moveDir = transform.TransformDirection(moveDir);

            if(Input.GetButton("Jump"))
            {
                moveDir.y = jumpSpeed;
            }
        }
        moveDir.y -= fGravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }
}
