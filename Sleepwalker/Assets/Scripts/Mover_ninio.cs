using UnityEngine;
using System.Collections;

public class Mover_ninio : MonoBehaviour {

    public float Velocidad = 0.3f; //Se recomienda 0.3 o 0.2
    Rigidbody2D rg;
    bool anda = true;

    // Use this for initialization
    void Start () {
	    rg = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (anda){
            Andando();
        }
        else {
            Detener();
        }
    }

    void Andando() {
        rg.velocity = new Vector2(Velocidad, 0);
    }

    void Detener() {
        rg.velocity = new Vector2(0, 0);
    }

    public void Controlador() {
        Debug.Log("Anda");
        anda = false;
    }
}
