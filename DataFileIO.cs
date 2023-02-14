using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class DataFileIO : MonoBehaviour
{
    string sLine;
    string[] sToken;
    StreamReader sr = null;

    void Start()
    {
        //sr = new StreamReader("Assets/0214/data.csv", Encoding.GetEncoding("euc-kr"));
        //while(!sr.EndOfStream)
        //{
        //    sLine = sr.ReadLine();
        //    sToken = sLine.Split(',');
        //    foreach(var data in sToken)
        //    {
        //         
        //    }
        //}
    }


    void Update()
    {
        
    }
}
