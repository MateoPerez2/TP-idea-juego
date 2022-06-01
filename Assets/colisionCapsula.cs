﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionCapsula : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public GameObject barrera;
    public float velocidadBarrera;
    Rigidbody rb;
    public float force;
    bool hasJump = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if(gameObject.transform.position != new Vector3 (6,1,0))
        {
            barrera.transform.Translate(0 ,-velocidadBarrera , 0);
        }
        if(Input.GetKeyDown(KeyCode.Space) && hasJump)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            hasJump = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Deathwall")
        {
            transform.position = new Vector3(6, 1, 0);
            barrera.transform.position = new Vector3(26, 5, -1.19f);
        }
        if (col.gameObject.tag == "ground")
        {
            hasJump = true;
        }
    }
}
