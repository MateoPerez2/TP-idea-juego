using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colisionCapsula : MonoBehaviour
{
    public float movementSpeed;
   //public float movementSpeed;
    public float rotationSpeed;
    public GameObject barrera;
    public float velocidadBarreraPersonaje;
    Rigidbody rb;
    public float force;
    bool hasJump = true;
    public Text levelsFinish;
    int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Translate(0, 0, -movementspeed);
        }*/
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += new Vector3(0,0,0.1f);
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if(gameObject.transform.position != new Vector3 (6,1,0))
        {
            barrera.transform.Translate(0 ,-velocidadBarreraPersonaje , 0);
            gameObject.transform.Translate(0, 0, velocidadBarreraPersonaje);
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
            transform.position = new Vector3(18,1, 0);
            barrera.transform.position = new Vector3(35, 5, -1.19f);
            level--;
        }
        if (col.gameObject.tag == "ground")
        {
            hasJump = true;
        }
        if (col.gameObject.tag == "finish")
        {
            level++;
            transform.position = new Vector3(18, 1, 0);
            barrera.transform.position = new Vector3(35, 5, -1.19f);
            velocidadBarreraPersonaje += 0.1f;
            levelsFinish.text = "Finished level " +level;
        }
    }
}
