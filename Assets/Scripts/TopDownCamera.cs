using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    public Camera cam;
    private Vector3 dragOrigin;
    public float zoomStep, minCamSize, maxCamSize;
    public float mapMinX, mapMaxX, mapMinY, mapMaxY;

    // Update is called once per frame
    void Update()
    {
        ZoomInOut();
        panCamera();
    }
    void panCamera()
    {
        if (Input.GetMouseButtonDown(0))
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);

            cam.transform.position = ClampCamera(cam.transform.position + difference);
        }
    }
    private Vector3 ClampCamera(Vector3 targetPosition)
    {
        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;

        float minX = mapMinX + camWidth;
        float maxX = mapMaxX - camWidth;
        float minY = mapMinY + camHeight;
        float maxY = mapMaxY - camHeight;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);

        return new Vector3(newX, newY, targetPosition.z);
    }
    public void ZoomInOut()
    {

        if (Input.mouseScrollDelta.y != 0)
        {

            if (Input.mouseScrollDelta.y > 0 )
            {
                float newSize = cam.orthographicSize - zoomStep;
                cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
            }
            if (Input.mouseScrollDelta.y < 0)
            {
                float newSize = cam.orthographicSize + zoomStep;
                cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
            }

        }
    }


}

