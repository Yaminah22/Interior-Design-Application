using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tabGroup : MonoBehaviour
{
    public List<tabButton> tabButtons;
    public Sprite tabIdle;
    public Sprite tabHover;
    public Sprite tabActive;
    public tabButton selectedtab;
    public List<GameObject> panels;
    public Texture2D cursorTexture;

    private void Start()
    {
        panels[0].SetActive(true);
    }

    // Function to add all tabs to this list whenever they are selected
    public void subscribe(tabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<tabButton>();
        }
        tabButtons.Add(button);
    }

    //this function is called every time a tab is clicked on
    public void onTabSelected(tabButton button)
    {
        selectedtab = button;
        resetTabs();
        button.background.sprite = tabActive;

        //Different panels are switched here according to the selected tab
        int index = button.transform.GetSiblingIndex();
        for(int i = 0; i < panels.Count; i++)
        {
            if (i==index)
            {
                panels[i].SetActive(true);
            }
            else
            {
                panels[i].SetActive(false);
            }
        }
    }

    //This function is called everytime we hover over a tab
    public void onTabEnter(tabButton button)
    {
        //Changing cursor on hover
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.ForceSoftware);
        resetTabs();
        if (selectedtab == null || button != selectedtab)
        {
            button.background.sprite = tabHover;
        }
    }

    //This function is called everytime a tab is exited as we click on another tab or hover on another tab
    public void onTabExit(tabButton button)
    {
        resetTabs();
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); //Changing cursor on exit
    }

    //This function resets all tabs backgrounds whenever a tab is clicked
    public void resetTabs()
    {
        
        foreach(tabButton button in tabButtons) 
        {
            if (selectedtab != null && button == selectedtab) { continue; }
            button.background.sprite = tabIdle;
        }
    }

}
