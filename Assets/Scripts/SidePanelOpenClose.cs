using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]

//This script opens and closes the side panels and enables switching between them
public class SidePanelOpenClose : MonoBehaviour,IPointerClickHandler
{
    public GameObject hiddenPanel;
    public GameObject mainSidePanel;
    public GameObject cameraControlView;
    public GameObject cameraControlDefault;
    public GameObject cameraTopDown;
    public GameObject cameraFirstPerson;
    
    public void OnPointerClick(PointerEventData eventData)
    {

        if (this.name == "view" || this.name == "back")
        {
            if (mainSidePanel.activeInHierarchy == false)
            {
                mainSidePanel.SetActive(true);
                hiddenPanel.SetActive(false);
                cameraControlView.SetActive(false);
                cameraControlDefault.SetActive(true);
                cameraFirstPerson.SetActive(false);
                cameraTopDown.SetActive(false);

            }
            else if (mainSidePanel.activeInHierarchy == true)
            {

                mainSidePanel.SetActive(false);
                hiddenPanel.SetActive(true);
                cameraControlView.SetActive(true);
                cameraControlDefault.SetActive(false);

            }
        }
        else if (this.name == "topDown")
        {
            if (cameraTopDown.activeInHierarchy == false)
            {
                cameraTopDown.SetActive(true);
                cameraFirstPerson.SetActive(false);
                cameraControlView.SetActive(false);
                cameraControlDefault.SetActive(false);
            }
            else if (cameraTopDown.activeInHierarchy == true)
            {
                cameraTopDown.SetActive(false);
                cameraFirstPerson.SetActive(false);
                cameraControlView.SetActive(true);
                cameraControlDefault.SetActive(false);
            }
        }
        else if (this.name == "FirstPerson")
        {
            if (cameraFirstPerson.activeInHierarchy == false)
            {
                cameraTopDown.SetActive(false);
                cameraFirstPerson.SetActive(true);
                cameraControlView.SetActive(false);
                cameraControlDefault.SetActive(false);
            }
            else if (cameraFirstPerson.activeInHierarchy == true)
            {
                cameraTopDown.SetActive(false);
                cameraFirstPerson.SetActive(false);
                cameraControlView.SetActive(true);
                cameraControlDefault.SetActive(false);
            }
        }


    }

   



}
