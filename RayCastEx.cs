using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastEx : MonoBehaviour
{

    public Material mat;
    LayerMask layMask;
    void Start()
    {
        layMask = LayerMask.NameToLayer("Target");
       
    }

    // Update is called once per frame

    public float fRow = 0;
    public float fCol = 0;
    public float Speed = 0;
    public float RotSpeed = 0;

    void Update()
    {
        print("layMask" + layMask);

        fRow = Input.GetAxis("Horizontal");
        fCol = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * fRow * RotSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * fCol * Speed * Time.deltaTime);

        Debug.DrawRay(transform.position, transform.forward * 10, Color.green, 0.5f);

        if (Input.GetKey(KeyCode.L))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10f))
            {
                Destroy(hit.collider.gameObject,0.5f) ;
            }
        }

        if (Input.GetKey(KeyCode.M))
        {
            RaycastHit[] Allhit;
            Allhit = Physics.RaycastAll(transform.position, transform.forward, 10f,1<<(int)layMask);
            
            for(int i = 1; i<Allhit.Length; i++)
            {
                //Destroy(Allhit[i].collider.gameObject);  
                // 아군은 안죽이게 하는것 - 레이어 마스크, 태그명 find
                print("Hit " + Allhit[i].transform.name);
                //if (Allhit[i].transform.tag.Equals("Enemy"))
                //{
                //    //Destroy(Allhit[i].transform.gameObject);
                //    Allhit[i].transform.GetComponent<MeshRenderer>().material = mat; //.color = Color.red;
                //}
            }
        }


    }
}
