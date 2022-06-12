using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtTime;
    public float customTime;
    public bool isCounting;
    public GameObject capsula;
    // Start is called before the first frame update
    void Start()
    {
        customTime = 0;
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time;
        txtTime.text = "Time:" +  customTime.ToString();

        if (isCounting)
        {
            customTime += Time.deltaTime;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Deathwall")
        {
            isCounting = false;
        }
    }

}
