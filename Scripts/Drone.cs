using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
        public int health = 500;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5.4f;
    }

    // Update is called once per frame
    void Update()
    {
        health -= 1;
    }
}
