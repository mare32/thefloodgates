using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;

public class Bunker : PlaceableBuilding, IPointerClickHandler
{
    public int maxZombiesInside = 20;
    public int currectZombiesInside = 0;
    void Update()
    {
        if (aboutToBePlaced)
        {
            PrepareAndPlace();
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {

    }
}
