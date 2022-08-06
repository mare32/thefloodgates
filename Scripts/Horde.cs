using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horde : MonoBehaviour
{
    Vector2 moveTowards;
    bool markerPlaced;
    Rigidbody2D rb;
    [Range(0f, 5f)]
    public float speed = 1.5f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        foreach (Selectable o in (Selectable[])FindObjectsOfType(typeof(Selectable)))
        {
            if( o.isSelected)
            {
                markerPlaced = true;
                moveTowards = o.transform.position;
                break;
            }
        }
        if(markerPlaced)
        {
            transform.position = Vector2.MoveTowards(transform.position,moveTowards,speed * Time.deltaTime);
        }
    }
}
