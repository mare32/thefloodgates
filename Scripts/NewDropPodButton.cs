using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;
using TMPro;
using UnityEngine.UI;

public class NewDropPodButton : MonoBehaviour, IPointerClickHandler
{
    public DropPod[] dropPods;
    public Bunker[] bunkers;
    public bool newBunker;
    public bool newDropPod;
    public SpriteRenderer spriteRenderer;
    public ResourceManager resourceManager;
    void Start()
    {
        // dodati text u start metodi
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        bunkers = (Bunker[])FindObjectsOfType(typeof(Bunker));
        dropPods = (DropPod[])FindObjectsOfType(typeof(DropPod));
    }

    private void OnMouseOver()
    {
        spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
    }
    private void OnMouseExit()
    {
        spriteRenderer.color = new Color(1f, 1f, 1f, .5f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
        if (newBunker)
        {
            foreach(Bunker bunker in bunkers)
            {
                if (bunker.aboutToBePlaced)
                {
                    bunker.aboutToBePlaced = false;
                    bunker.transform.position = bunker.startingPosition;
                    break;
                }
            }
            foreach(Bunker bunker in bunkers)
            {
                if(!bunker.isPlaced && resourceManager.availableScrap > bunker.scrapCost)
                {
                    bunker.aboutToBePlaced = true;
                    bunker.spriteRenderer.color = new Color(.1f, 1f, .1f, .2f);
                    break;
                }
            }
        }
        else if(newDropPod)
        {
            foreach (DropPod dropPod in dropPods)
            {
                if (dropPod.aboutToBePlaced)
                {
                    dropPod.aboutToBePlaced = false;
                    dropPod.transform.position = dropPod.startingPosition;
                    break;
                }
            }
            foreach (DropPod dropPod in dropPods)
            {
                if (!dropPod.isPlaced && resourceManager.availableScrap > dropPod.scrapCost)
                {
                    dropPod.aboutToBePlaced = true;
                    dropPod.spriteRenderer.color = new Color(.1f, 1f, .1f, .2f);
                    break;
                }
            }
        }
            
    }
}
