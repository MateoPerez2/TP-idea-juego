using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantite : MonoBehaviour
{
    public float speed;
    public GameObject prefab1;
    GameObject clone;
    float posX = -329.9511f;
    float posY = 11.02f;
    float posZ = -4.28f;
    void Start()
    {
        
    }

    
    void Update()
    {
        for(int i=0; i < 5; i++)
        {
            
            clone = Instantiate(prefab1);
            clone.transform.position = new Vector3(posX, posY, posZ);
            posZ++;
            Destroy(clone, 0.5f);
            
        }
        for(int i=5; i > 0; i--)
        {
            clone = Instantiate(prefab1);
            clone.transform.position = new Vector3(posX, posY, posZ);
            posZ --;
            Destroy(clone, 0.5f);
            
        }
    }
}
