using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barreraDeathwall : MonoBehaviour
{
    float traslacionBarrera = 0;
    GameObject Capsule;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (Capsule.transform.position != new Vector3 (6, 1, 0))
        {
            transform.Translate(traslacionBarrera, 0, 0);
            traslacionBarrera++;
        }
    }
}
