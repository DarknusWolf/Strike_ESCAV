using UnityEngine;
using System.Collections;

public class Fantasma : MonoBehaviour {

    public float desplazamiento_movimiento = 9f;
    public float desplazamiento_salto = 9f;
    Rigidbody2D rg;

    // Use this for initialization
    void Start () {
        rg = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W)){ //Arriba
            rg.velocity = new Vector2(0, desplazamiento_salto); //rg.transform.position.x     //Ajustar que el lanzamiento para que no sea tan cortado.
        }

        if (Input.GetKeyDown(KeyCode.D)){ //Derecha
            rg.velocity = new Vector2(desplazamiento_movimiento, 0);
        }

        if (Input.GetKeyDown(KeyCode.A)){ //Izquierda
            rg.velocity = new Vector2(-desplazamiento_movimiento, 0);
        }

        /*if (Input.GetKeyDown(KeyCode.Space)){

        }*/
    }
}
