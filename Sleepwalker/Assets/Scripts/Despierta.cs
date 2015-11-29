﻿using UnityEngine;
using System.Collections;

public class Despierta : MonoBehaviour {
    public float fuerza = 6;
    public GameObject go;
    public Rigidbody2D rg;
    public Animator an; //Cuando este el personaje
    public Animator an2; //Cuando este el personaje
    private Mover_ninio scriptmover;

    // Use this for initialization
    void Start () {
        scriptmover = go.GetComponent<Mover_ninio>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D objeto){ 
        if (objeto.transform.tag == "Ninio"){
            scriptmover.Controlador();
            rg.AddForce(new Vector2(0, fuerza));
            an.SetBool("Susto", true);
            an2.SetBool("Susto", true);
        }
    }
}
