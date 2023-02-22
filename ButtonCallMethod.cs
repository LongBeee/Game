using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCallMethod : MonoBehaviour
{
    Image img;
    float Amount = 1;
    void Start()
    {
        img = GameObject.Find("HpGage").GetComponent<Image>();
        img.fillOrigin = (int)Image.Origin360.Top;
    }

    public void lButtonClick()
    {
        Amount -= 0.1f;
        print("Left Button Clicked" + img.name);
        img.fillAmount = Amount;
    }
    public void rButtonClick()
    {
        Amount += 0.1f;
        print("Right Button Clicked" + img.name);
        img.fillAmount = Amount;
    }

    void Update()
    {
        
    }
}
