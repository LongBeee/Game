using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScore : MonoBehaviour
{
    public float fTime = 0;
    public int Score = 0;
    public Text TScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fTime += Time.deltaTime;

        if (fTime > 1)
        {
            Score += 10;
            TScore.text = "Score : " + Score + "";
            print(Score);
            fTime = 0;
        }
    }
}
