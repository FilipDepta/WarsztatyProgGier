using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class przeciwnik : MonoBehaviour
{

    float szybkoscPrzeciwnika = 1;
    public GameObject nabojprow;
    private float timer = 0.0f;

    void Start()
    {

    }

    void Update()
    {
        /*   
              timer += Time.deltaTime;
              if (globals.zycia > 1 && timer > 2.0f)
              {

                  Vector3 pozycja = new Vector3(transform.position.x + (transform.localScale.x / 2 + 1), transform.position.y, transform.position.z);
                  Instantiate(nabojprow, pozycja, Quaternion.identity);
                  Destroy(nabojprow);

              }        
              */
    }


    public void RuchPrzeciwnika()
    {

        float ruch = szybkoscPrzeciwnika * Time.deltaTime;
        transform.Translate(Vector3.left * ruch);

    }
}
