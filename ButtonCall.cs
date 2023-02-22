using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCall : MonoBehaviour
{
    public Text Score_text;
    float Score = 0;
    void Start()
    {
        
    }

    void Update()
    {
        //if(Score_txt == 0)
        //{
        //    return;
        //}
    }

    public void CalledFromButton1()
    {
        //print("Called From Button1");
        Score += 10;
        Score_text.text = Score + "";
    }

    public void CalledFromButton2()
    {
        //print("Called From Button2");
        Score -= 10;
        Score_text.text = Score + "";
    }
}
