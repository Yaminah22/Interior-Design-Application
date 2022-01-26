using UnityEngine;
using UnityEngine.UI;

public class Zoomer : MonoBehaviour
{
    public Button zoomInButton;
    public Button zoomOutButton;
    public float movementTime;
    public float zoomDelta = 0.1f;
    public Transform camTransform;
    public Vector3 newZoom;
    public float minZ;
    public float maxZ;

    void OnEnable()
    {
        zoomInButton.onClick.AddListener(delegate { Zoom(-zoomDelta); });
        zoomOutButton.onClick.AddListener(delegate { Zoom(zoomDelta); });
    }

    void Zoom(float value)
    {
        newZoom=camTransform.localPosition;
        newZoom.z = Mathf.Clamp(newZoom.z + value, minZ, maxZ);
        
        camTransform.localPosition = Vector3.Lerp(camTransform.localPosition, newZoom, Time.deltaTime * movementTime);

    }
}