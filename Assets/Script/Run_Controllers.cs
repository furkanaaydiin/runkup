using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_Controllers : MonoBehaviour
{
   public Rigidbody2D rb;
   public float minX;
   public float maxX;
   public float lifeTİme;
    void Start()
    {
        rb.velocity = new Vector2(Random.Range(maxX,minX),-transform.position.y);

        Destroy(gameObject, lifeTİme);
    }
}

    
    
