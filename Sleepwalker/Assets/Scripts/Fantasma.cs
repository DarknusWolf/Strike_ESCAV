using UnityEngine;
using System.Collections;

public class Fantasma : MonoBehaviour {

    public float desplazamiento_movimiento = 9f;
    public float desplazamiento_salto = 9f;
    Vector3 mira_derecha = new Vector3(-0.6961414f, 0.6961414f, 0.6961414f); //Cambiar segun el tamaño final
    Vector3 mira_izquierda = new Vector3(0.6961414f, 0.6961414f, 0.6961414f);
    Vector3 mira_delante1 = new Vector3(-0.6261414f, 0.6261414f, 0.6261414f);
    Vector3 mira_delante2 = new Vector3(0.6261414f, 0.6261414f, 0.6261414f);

    Rigidbody2D rg;
    Animator an;


    // Use this for initialization
    void Start () {
        rg = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)){ //Arriba
            transform.localScale = mira_delante2;
            an.SetBool("Mover", false);
            rg.velocity = new Vector2(rg.velocity.x, desplazamiento_salto); //rg.transform.position.x     //Ajustar que el lanzamiento para que no sea tan cortado.
        }

        if (Input.GetKey(KeyCode.D)){ //Derecha
            transform.localScale = mira_derecha;
            an.SetBool("Mover", true);
            rg.velocity = new Vector2(desplazamiento_movimiento, rg.velocity.y);
        }

        if (Input.GetKey(KeyCode.A)){ //Izquierda
            transform.localScale = mira_izquierda;
            an.SetBool("Mover", true);
            rg.velocity = new Vector2(-desplazamiento_movimiento, rg.velocity.y);
        }

        if (Input.GetKeyUp(KeyCode.A)){
            transform.localScale = mira_delante2;
            an.SetBool("Mover", false);
        }

        if(Input.GetKeyUp(KeyCode.D)){
            transform.localScale = mira_delante1;
            an.SetBool("Mover", false);
        }
    }
}
