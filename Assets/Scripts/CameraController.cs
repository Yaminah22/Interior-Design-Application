using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform cameraTransform;
    public float movementSpeed;
    public float movementTime;
    public float rotationAmount;
    public Vector3 zoomAmount;

    public Vector3 newPosition;
    public Quaternion newRotation;
    public Vector3 newZoom;

    public Vector3 dragStartPosition;
    public Vector3 dragCurrentPosition;
    public Vector3 rotateStartPosition;
    public Vector3 rotateCurrentPosition;
   
    public float minZoom;
    public float maxZoom;
    public float minZ;
    public float maxZ;
    public float minX;
    public float maxX; 

    // Start is called before the first frame update
    void Start()
    {
        newPosition = transform.position;
        newRotation = transform.rotation;
        newZoom = cameraTransform.localPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovementInput();
       
    }

    //Function for handling keyboard input for movement and zoom
    void HandleMovementInput()
    {
        if((Input.GetKey(KeyCode.W)  || Input.GetKey(KeyCode.UpArrow)) && newPosition.z< maxZ)
        {
            newPosition += (transform.forward * movementSpeed);
        }
        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && newPosition.z>minZ)
        {
            newPosition += (transform.forward * -movementSpeed);
        }
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && newPosition.x < maxX)
        {
            newPosition += (transform.right * movementSpeed);
        }
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && newPosition.x > minX)
        {
            newPosition += (transform.right * -movementSpeed);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            newRotation *= Quaternion.Euler(Vector3.up * rotationAmount);
        }
        if (Input.GetKey(KeyCode.E))
        {
            newRotation *= Quaternion.Euler(Vector3.up * -rotationAmount);
        }
        if (Input.GetKey(KeyCode.R) && newZoom.z < minZoom)
        {
            newZoom += zoomAmount;
        }
        if (Input.GetKey(KeyCode.F) && newZoom.z > maxZoom)
        {
            newZoom -= zoomAmount;
        }
        
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementTime);
        transform.rotation = Quaternion.Lerp(transform.rotation,newRotation,Time.deltaTime * movementTime);
        cameraTransform.localPosition = Vector3.Lerp(cameraTransform.localPosition, newZoom, Time.deltaTime * movementTime);
    
    }
}
