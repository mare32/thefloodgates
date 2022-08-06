using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;
public class PlaceableBuilding : MonoBehaviour
{
    public bool aboutToBePlaced;
    public bool isPlaced;
    public SpriteRenderer spriteRenderer;
    public bool cantPlaceThere;
    public Vector2 startingPosition;
    public int scrapCost;
    public ResourceManager resourceManager;
    void Start()
    {
        resourceManager = GameObject.FindObjectOfType<ResourceManager>();
        startingPosition = transform.position;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void PrepareAndPlace()
    {

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        Vector3 Worldpos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 Worldpos2D = new Vector2(Worldpos.x, Worldpos.y);
        transform.position = Worldpos2D;

        if (Input.GetMouseButtonDown(0) && !cantPlaceThere)
        {
            resourceManager.SpendScrap(scrapCost);
            transform.position = Worldpos2D;
            aboutToBePlaced = false;
            isPlaced = true;
            spriteRenderer.color = Color.white;
        }
        if(Input.GetMouseButtonUp(1))
        {
            transform.position = startingPosition;
            aboutToBePlaced = false;
            spriteRenderer.color = Color.white;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!isPlaced)
        {
            cantPlaceThere = true;
            spriteRenderer.color = new Color(.5f, .1f, .1f, .2f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!isPlaced)
        {
            cantPlaceThere = false;
            spriteRenderer.color = new Color(.1f, 1f, .1f, .2f);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!isPlaced)
        {
            cantPlaceThere = true;
            spriteRenderer.color = new Color(.5f, .1f, .1f, .2f);
        }
    }
}
