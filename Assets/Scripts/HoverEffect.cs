using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]

public class HoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,IPointerClickHandler
{
    public Texture2D texture;
    public Sprite buttonIdle;
    public Sprite buttonHover;
    public Sprite buttonSelected;

    public void OnPointerClick(PointerEventData eventData)
    {
        this.gameObject.GetComponent<Image>().sprite = buttonSelected;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Changing cursor on hover
        Cursor.SetCursor(texture, Vector2.zero, CursorMode.ForceSoftware);
        this.gameObject.GetComponent<Image>().sprite = buttonHover;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); //Changing cursor on exit
        this.gameObject.GetComponent<Image>().sprite = buttonIdle;
    }


    
}
