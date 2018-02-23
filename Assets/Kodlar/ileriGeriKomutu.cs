using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ileriGeriKomutu : MonoBehaviour
{
    public int posizyonX, posizyonY, posizyonZ;
    int tekrar;

    // Use this for initialization
    void Start ()
    {
        tekrar = 0;
    }



    bool yon = false;
	// Update is called once per frame
	void Update ()
    {
        //if(transform.position.z > 86.73f)
        //{
        //    yon = true;
        //}
        //else if(transform.position.z < 58.23)
        //{
        //    yon = false;
        //}

        //tekrar++;
        //if (transform.position.z < 86.73f && yon == false)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (tekrar * 0.01f));

        //}
        //else if (transform.position.z > 58.23f && yon == true)
        //{
        //    tekrar = 0;
        //    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (tekrar * 0.01f));
        //}


        tekrar++;

        if (tekrar > 160)
            tekrar = 0;

        if (tekrar < 80)
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (tekrar * 0.01f));
        else
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (tekrar * 0.01f));

        
    }
}
