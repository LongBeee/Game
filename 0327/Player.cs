using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    Animator anim;
    Transform cameraArm; //카메라방향을 찾기 위한 카메라
    CharacterController controller; //이동을 하기 위한 선언

    public float speed = 5.0f; //기본 속도
    public float runSpeed = 8f; //달리는 속도
    public float finalSpeed; //최종적인 속도

    public bool run; //달리는 모션을 위한 Bool문

    public float RotSpeed = 10;

    Vector3 MoveDir;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();  //자신 아이가 가지고 있는 애니메이션컴포넌트 뜯어오기
        cameraArm = GameObject.Find("Camera").transform; //카메라 찾기

        controller = this.GetComponent<CharacterController>(); //캐릭터 컨트롤러 뜯어오기
    }

    void Update()
    {
        //왼쪽 쉬프트를 눌렀을 때 빠르게 달리기
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true; //빠르게 뛰기
        }
        else
        {
            run = false; //그냥 뛰기
        }

        InputMoveMent();
    }

    private bool isJumping = false;
    private float jumpHeight = 2f;
    private float gravity = -9.81f;
    private Vector3 velocity;

    void InputMoveMent()
    {
        finalSpeed = (run) ? runSpeed : speed; //run이 활성화 됬다면 runSpeed 비활성화됬다면 speed

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        //입력축값들 받아오기

        if (controller.isGrounded)
        {
            transform.Rotate(Vector3.up * RotSpeed * moveInput * Time.deltaTime);
            MoveDir = new Vector3(0, moveInput.y);
            isJumping = false;
        }

        bool isMove = moveInput.magnitude != 0; //입력축이 0이 아니면 true

        if (isMove)
        {
            Vector3 forward = new Vector3(cameraArm.forward.x, 0f, cameraArm.forward.z).normalized;
            //카메라의 정면값 받아오기

            Vector3 right = new Vector3(cameraArm.right.x, 0f, cameraArm.right.z).normalized;
            //카메라의 오른쪽값 받아오기

            Vector3 moveDir = forward * moveInput.y + right * moveInput.x;
            //카메라의 정면값*앞뒤값 + 카메라의 오른쪽값*좌우값

            transform.forward = moveDir;
            //카메라를 기준으로 캐릭터의 앞뒤좌우값이 변화, moveDir를 forward값으로 바꾸면 캐릭터가 카메라가 보고 있는 곳만을 바라봄

            controller.Move(moveDir.normalized * finalSpeed * Time.deltaTime);
            //캐릭터컨트롤러전용 이동 메서드           
        }

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            anim.SetFloat("Blend2", gravity, 0.1f, Time.deltaTime);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        float percent = ((run) ? 1 : 0.5f) * moveInput.magnitude; //애니메이션 적용 마지막에 moveInput을 곱하는 이유는 0의 값도 받기 위함
        anim.SetFloat("Blend", percent, 0.1f, Time.deltaTime); //.Blend에 있는 애니메이션을 0, 0.5, 1에 따라 다르게 출력하며, 애니메이션의 변화값을 몇초 줄지 정하는 값 

    }
}