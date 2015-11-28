using UnityEngine;
using System.Collections;

public class activador_boton : MonoBehaviour {
    public Animator Target; //meter animacion puerta
    bool dentro = false;
    Animator mi_animacion;

    void Start(){
        mi_animacion = GetComponent<Animator>(); //animacion palanca
    }

    void Update(){
        if (Input.GetKey(KeyCode.Space) && dentro){
            activar();
        }

        if (Input.GetKeyUp(KeyCode.Space) || !dentro){
            desactivar();
        }
    }

    void OnTriggerEnter2D(Collider2D objeto){
        if (objeto.transform.tag == "Player"){
            dentro = true;
        }
    }


    void OnTriggerExit2D(Collider2D objeto){
        dentro = false;
    }

    void activar(){
        Target.SetBool("Activar", true);
        mi_animacion.SetBool("Activar", true);
    }

    void desactivar(){
        Target.SetBool("Activar", false);
        mi_animacion.SetBool("Activar", false);
    }
}
