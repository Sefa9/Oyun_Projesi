﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTest : MonoBehaviour {

	GameObject bitisMesaji; //Obje sınıfını çağır
	Vector3 spawnAlani=new Vector3(-1.51f, 8.31f, -2.16f); //3 boyutlu lokasyon oluştur
	void Start () {
		bitisMesaji = GameObject.Find("bittiMesaji"); //İsimden obje çağır.
	}


	void Update () {

        if (transform.position.y < 6.0)
        { // Y ekseni 0 dan küçük ise 
            bitisMesaji.active = true; //objeyi göster
            StartCoroutine(beklet()); //Enumerator sırasını aktifleştir
        }
        else
        {
            //Debug.Log (transform.position);
            bitisMesaji.active = false; //objeyi sil
        }
		
	}

	IEnumerator beklet() //Enumerator sırası oluştur. Iteretor olarak,
	{
		yield return new WaitForSeconds (2); //sırada 2 saniye bekle
		transform.position = spawnAlani; //spawn gönder
	}
}
