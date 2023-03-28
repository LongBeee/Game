using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    Animator anim;
    Transform cameraArm; //ī�޶������ ã�� ���� ī�޶�
    CharacterController controller; //�̵��� �ϱ� ���� ����

    public float speed = 5.0f; //�⺻ �ӵ�
    public float runSpeed = 8f; //�޸��� �ӵ�
    public float finalSpeed; //�������� �ӵ�

    public bool run; //�޸��� ����� ���� Bool��

    public float RotSpeed = 10;

    Vector3 MoveDir;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();  //�ڽ� ���̰� ������ �ִ� �ִϸ��̼�������Ʈ ������
        cameraArm = GameObject.Find("Camera").transform; //ī�޶� ã��

        controller = this.GetComponent<CharacterController>(); //ĳ���� ��Ʈ�ѷ� ������
    }

    void Update()
    {
        //���� ����Ʈ�� ������ �� ������ �޸���
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true; //������ �ٱ�
        }
        else
        {
            run = false; //�׳� �ٱ�
        }

        InputMoveMent();
    }

    private bool isJumping = false;
    private float jumpHeight = 2f;
    private float gravity = -9.81f;
    private Vector3 velocity;

    void InputMoveMent()
    {
        finalSpeed = (run) ? runSpeed : speed; //run�� Ȱ��ȭ ��ٸ� runSpeed ��Ȱ��ȭ��ٸ� speed

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        //�Է��ప�� �޾ƿ���

        if (controller.isGrounded)
        {
            transform.Rotate(Vector3.up * RotSpeed * moveInput * Time.deltaTime);
            MoveDir = new Vector3(0, moveInput.y);
            isJumping = false;
        }

        bool isMove = moveInput.magnitude != 0; //�Է����� 0�� �ƴϸ� true

        if (isMove)
        {
            Vector3 forward = new Vector3(cameraArm.forward.x, 0f, cameraArm.forward.z).normalized;
            //ī�޶��� ���鰪 �޾ƿ���

            Vector3 right = new Vector3(cameraArm.right.x, 0f, cameraArm.right.z).normalized;
            //ī�޶��� �����ʰ� �޾ƿ���

            Vector3 moveDir = forward * moveInput.y + right * moveInput.x;
            //ī�޶��� ���鰪*�յڰ� + ī�޶��� �����ʰ�*�¿찪

            transform.forward = moveDir;
            //ī�޶� �������� ĳ������ �յ��¿찪�� ��ȭ, moveDir�� forward������ �ٲٸ� ĳ���Ͱ� ī�޶� ���� �ִ� ������ �ٶ�

            controller.Move(moveDir.normalized * finalSpeed * Time.deltaTime);
            //ĳ������Ʈ�ѷ����� �̵� �޼���           
        }

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            anim.SetFloat("Blend2", gravity, 0.1f, Time.deltaTime);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        float percent = ((run) ? 1 : 0.5f) * moveInput.magnitude; //�ִϸ��̼� ���� �������� moveInput�� ���ϴ� ������ 0�� ���� �ޱ� ����
        anim.SetFloat("Blend", percent, 0.1f, Time.deltaTime); //.Blend�� �ִ� �ִϸ��̼��� 0, 0.5, 1�� ���� �ٸ��� ����ϸ�, �ִϸ��̼��� ��ȭ���� ���� ���� ���ϴ� �� 

    }
}