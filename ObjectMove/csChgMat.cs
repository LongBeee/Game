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
        mat = Resources.LoadAll<Material>("Mater"); // LoadAll - 전체파일
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            int num = Random.Range(0,mat.Length);     // 왼쪽 매개변수 값부터 오른쪽 값까지의 범위의 값들을 랜덤하게 출력하는 함수 - Random.Range()
            box.GetComponent<MeshRenderer>().material = mat[num];
        }
    }
}