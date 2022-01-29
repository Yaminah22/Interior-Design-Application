using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cubeRoom : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        float width = 6.01f;
        float length = 4.88f;
        GameObject floor = GameObject.Find("floor");
        
        floor.transform.localScale = new Vector3(length,0.4f,width);

        GameObject wallBack = GameObject.Find("wallBack");
        wallBack.transform.localScale = new Vector3((float)Math.Round(length), 2.75f, 0.1f);
        wallBack.transform.localPosition = new Vector3(0f, 1f, -(float)Math.Round(width)/2);

        GameObject wallFront = GameObject.Find("wallFront");
        wallFront.transform.localScale = new Vector3((float)Math.Round(length), 2.75f, 0.1f);
        wallFront.transform.localPosition = new Vector3(0f, 1f, (float)Math.Round(width) / 2);

        GameObject wallRight = GameObject.Find("wallRight");
        wallRight.transform.localScale = new Vector3((float)Math.Round(width), 2.75f, 0.1f);
        wallRight.transform.localPosition = new Vector3((float)Math.Round(length)/2, 1f, 0f);

        GameObject wallLeft = GameObject.Find("wallLeft");
        wallLeft.transform.localScale = new Vector3((float)Math.Round(width), 2.75f, 0.1f);
        wallLeft.transform.localPosition = new Vector3(-(float)Math.Round(length) / 2, 1f, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
