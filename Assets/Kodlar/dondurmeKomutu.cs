using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondurmeKomutu : MonoBehaviour
{

    public int donusHiziX, donusHiziY,donusHiziZ;
    byte tekrar;
	// Use this for initialization
	void Start ()
    {
        tekrar = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(donusHiziX * Time.deltaTime, donusHiziY * Time.deltaTime , donusHiziZ * Time.deltaTime);


        //tekrar++;
        //if (tekrar < 125)
        //    transform.Rotate(donusHiziX * Time.deltaTime, donusHiziY * Time.deltaTime , donusHiziZ * Time.deltaTime);
        //else
        //    transform.Rotate(donusHiziX * Time.deltaTime, -donusHiziY * Time.deltaTime, donusHiziZ * Time.deltaTime);

        //if (tekrar > 250)
        //    tekrar = 0;
    }
}
