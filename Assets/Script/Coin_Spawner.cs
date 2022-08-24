using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner : MonoBehaviour
{
   [SerializeField] GameObject[] spawnobje;
   [SerializeField] float startTİme;
   [SerializeField] float maxX;
   [SerializeField] float minX;
    float time;
    
   
    
    void Update()
    {
        if(time <= 0)
        {
            spawncoin();
            time = startTİme;
        }
        else
        {
            time -= Time.deltaTime;
        }
        
    }

    void spawncoin()
    {
        GameObject randomgameobject = spawnobje[Random.Range(0,spawnobje.Length)];
        randomgameobject = Instantiate(randomgameobject);
        randomgameobject.transform.position = new Vector2 (Random.Range(maxX,minX),transform.position.y);    
        
    }
}
