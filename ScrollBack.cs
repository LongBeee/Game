using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBack : MonoBehaviour
{
    public Material mat;
    void Start()
    {
        //mat = transform.GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset += Vector2.up * 2.0f * Time.deltaTime;
    }
}
