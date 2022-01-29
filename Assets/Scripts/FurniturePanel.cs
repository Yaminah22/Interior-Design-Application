using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class FurniturePanel : MonoBehaviour
{

	public GameObject selectedObject;
	public Camera cam;
	private Quaternion newRotation;
	public float movementTime;
	public float rotationAmount;
	public Vector3 rotateStartPosition;
	public Vector3 rotateCurrentPosition;
	public LayerMask wall;

	// Use this for initialization
	void Start()
	{
		cam = GameObject.Find("CameraRoom1").GetComponent<Camera>();
		newRotation = transform.rotation;
	}
    
    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
			if (selectedObject == null)
			{
			
				Ray ray = cam.ScreenPointToRay(Input.mousePosition);
				RaycastHit hitInfo;

				Physics.Raycast(ray, out hitInfo, wall);
				GameObject hitObject = hitInfo.transform.root.gameObject;
				SelectObject(hitObject);

			}
		}
		else if (Input.GetMouseButtonDown(1))
        {
			if (selectedObject == null)
			{
				
				Ray ray = cam.ScreenPointToRay(Input.mousePosition);
				RaycastHit hitInfo;

				Physics.Raycast(ray, out hitInfo, wall);
				GameObject hitObject = hitInfo.transform.root.gameObject;
				SelectObject(hitObject);
				HandleInput(hitObject);
			}
			
		}
        else
        {
			ClearSelection();
        }
       
		
		
    }
    
	void SelectObject(GameObject obj)
	{
		if (selectedObject != null)
		{
			if (obj == selectedObject)
				return;

			ClearSelection();
		}

		selectedObject = obj;

		Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
		foreach (Renderer r in rs)
		{
			Material m = r.material;
			m.color = Color.green;
			r.material = m;
		}
	}

	void ClearSelection()
	{
		if (selectedObject == null)
			return;

		Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
		foreach (Renderer r in rs)
		{
			Material m = r.material;
			m.color = Color.white;
			r.material = m;
		}
		selectedObject = null;
	}

	public void HandleInput(GameObject h)
	{
		h.transform.Rotate(0f,90f,0f,Space.World);

	}

	
}