using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_Spawner : MonoBehaviour
{
    
    public float startTİme;
    public float minX;
    public float maxX;
    float time;
    public GameObject[] objects;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        if(time <= 0)
        {
            RunSpawner();
            time = startTİme;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }

    void RunSpawner()
    { 
      transform.position = new Vector2(Random.Range(minX,maxX),transform.position.y);
      GameObject randomgameobject = objects[Random.Range(0,objects.Length)];
      randomgameobject = Instantiate(randomgameobject);
    }
}
