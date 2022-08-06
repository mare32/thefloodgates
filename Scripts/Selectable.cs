using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;
public class Selectable : MonoBehaviour, IPointerClickHandler
{
    public bool isSelected;
    public SpriteRenderer _spriteRenderer;
    public void Start()
    {
        _spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        foreach(Selectable o in (Selectable[])FindObjectsOfType(typeof(Selectable)))
        {
            o.isSelected = false;
            o._spriteRenderer.color = Color.white;
        }
        isSelected = !isSelected;
        if (isSelected)
            _spriteRenderer.color = Color.black;
        else
            _spriteRenderer.color = Color.white;
    }
}
