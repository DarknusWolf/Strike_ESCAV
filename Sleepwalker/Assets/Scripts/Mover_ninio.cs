using UnityEngine;
using System.Collections;

public class Mover_ninio : MonoBehaviour {

    public float Velocidad = 0.3f; //Se recomienda 0.3 o 0.2
    Rigidbody2D rg;

    // Use this for initialization
    void Start () {
	    rg = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rg.velocity = new Vector2(Velocidad, 0);
    }
}
