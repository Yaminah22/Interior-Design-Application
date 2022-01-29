
using UnityEngine;

public class moveFurniture : MonoBehaviour { 
    
    public Camera cam;
    public Vector3 dragStartPosition;
    public Vector3 dragCurrentPosition;
    public Vector3 newPosition;
    
    private void Start()
    {
        cam = GameObject.Find("CameraRoom1").GetComponent<Camera>();
        newPosition = transform.position;
    }

    void OnMouseDown()
    {
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        float entry;
        if (plane.Raycast(ray, out entry))
        {
            dragStartPosition = ray.GetPoint(entry);
        }
    }
    void OnMouseDrag()

    {
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        float entry;
        if (plane.Raycast(ray, out entry) )
        {
            dragCurrentPosition = ray.GetPoint(entry);
            transform.position = newPosition + dragCurrentPosition- dragStartPosition ;
        }
        
    }
}

