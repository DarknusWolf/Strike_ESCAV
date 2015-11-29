using UnityEngine;
using System.Collections;

public class Despierta : MonoBehaviour {
    public float fuerza = 6;
    public GameObject go;
    public Rigidbody2D rg;
    public Animator an; //Cuando este el personaje

    //private var Script1;

    // Use this for initialization
    void Start () {
        //Script1 = go.GetComponent("Mover_ninio");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D objeto){ 
        if (objeto.transform.tag == "Ninio"){
            //Script1.
            rg.AddForce(new Vector2(0, fuerza));
            an.SetBool("Susto", true);
        }
    }
}
