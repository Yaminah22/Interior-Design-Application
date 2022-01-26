using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]

public class tabButton : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler
{
    public tabGroup tabGroups;
    public Image background;

    //Separate functions for mouse click entry and exit implemented using event system library

    //on clicked function
    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroups.onTabSelected(this);
    }

    //on exit function i.e another tab is selected
    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroups.onTabExit(this);
    }

    //on entry / hover function
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        tabGroups.onTabEnter(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Image>();
        tabGroups.subscribe(this);
        
    }
}
