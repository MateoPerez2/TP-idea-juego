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
    float level = 1;
    public GameObject reset;
    public GameObject img;
    public GameObject txt;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        reset.gameObject.SetActive(false);
        img.gameObject.SetActive(false);
        txt.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
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
            transform.position = new Vector3(23,1, 0);
            barrera.transform.position = new Vector3(40, 5, -1.19f);
            reset.gameObject.SetActive(true);
            img.gameObject.SetActive(true);
            txt.gameObject.SetActive(true);
        }
        if (col.gameObject.tag == "ground")
        {
            hasJump = true;
        }
        if (col.gameObject.tag == "finish")
        {
            level++;
            transform.position = new Vector3(23, 1, 0);
            barrera.transform.position = new Vector3(40, 5, -1.19f);
            if(velocidadBarreraPersonaje > 0.3f)
            {
                velocidadBarreraPersonaje += 0.05f;
            }
            else
            {
                velocidadBarreraPersonaje += 0.1f;
            }
            
            levelsFinish.text = "Level " + level;
        }
    }
}
