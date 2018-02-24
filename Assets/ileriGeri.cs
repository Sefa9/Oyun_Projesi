using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ileriGeri : MonoBehaviour {

	// -------67  ______  77------ 

	void Start () {
		
	}


    float arttir;
    bool dokundu = false;
	void Update () {

        if (transform.position.z > 77)
        {
            dokundu = true;
        }
        else if (transform.position.z < 67)
            dokundu = false;

        if (transform.position.z < 77 && dokundu == false)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + arttir);
        }
        else if (transform.position.z > 67 && dokundu == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - arttir);
        }
        arttir += 0.1f;
        if (arttir > 0.4)
            arttir = 0.0f;

    }
}
