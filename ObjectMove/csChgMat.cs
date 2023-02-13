using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csChgMat : MonoBehaviour
{
    Material[] mat;
    GameObject box;
    // Start is called before the first frame update
    void Start()
    {
        box = GameObject.Find("Cube");
        mat = Resources.LoadAll<Material>("Mater"); // LoadAll - ��ü����
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            int num = Random.Range(0,mat.Length);     // ���� �Ű����� ������ ������ �������� ������ ������ �����ϰ� ����ϴ� �Լ� - Random.Range()
            box.GetComponent<MeshRenderer>().material = mat[num];
        }
    }
}