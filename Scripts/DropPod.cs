using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;

public class DropPod : PlaceableBuilding, IPointerClickHandler
{
    public int startHordeValue = 5;
    public int remainingHordeValue = 5;

    void Update()
    {
        if(aboutToBePlaced)
        {
            PrepareAndPlace();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }
}
