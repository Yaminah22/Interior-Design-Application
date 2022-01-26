using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cubeRoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float width = 20f;
        float height = 16f;
        GameObject floor = GameObject.Find("floor");
        
        floor.transform.localScale = new Vector3((float)Math.Round(height/2),0.4f, (float)Math.Round(width/2));

        GameObject wallBack = GameObject.Find("wallBack");
        wallBack.transform.localScale = new Vector3((float)Math.Round(height / 2), 2f, 0.1f);
        wallBack.transform.localPosition = new Vector3(0f, 0.95f, -(float)Math.Round(width / 2)/2);

        GameObject wallFront = GameObject.Find("wallFront");
        wallFront.transform.localScale = new Vector3((float)Math.Round(height / 2), 2f, 0.1f);
        wallFront.transform.localPosition = new Vector3(0f, 0.95f, (float)Math.Round(width / 2) / 2);

        GameObject wallRight = GameObject.Find("wallRight");
        wallRight.transform.localScale = new Vector3((float)Math.Round(width / 2), 2f, 0.1f);
        wallRight.transform.localPosition = new Vector3((float)Math.Round(height / 2)/2, 0.95f, 0f);

        GameObject wallLeft = GameObject.Find("wallLeft");
        wallLeft.transform.localScale = new Vector3((float)Math.Round(width / 2), 2f, 0.1f);
        wallLeft.transform.localPosition = new Vector3(-(float)Math.Round(height / 2) / 2, 0.95f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
