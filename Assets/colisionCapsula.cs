using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionCapsula : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Rotate(0, -rotationSpeed, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Deathwall")
        {
            Destroy(gameObject);
        }
    }
}
