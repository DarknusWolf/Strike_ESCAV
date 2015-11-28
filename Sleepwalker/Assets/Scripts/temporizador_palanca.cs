using UnityEngine;
using System.Collections;

public class temporizador_palanca : MonoBehaviour {
	public float tiempo = 3f;
	public Animator Target; //meter animacion puerta
	bool dentro = false;
	Animator mi_animacion;

	void Start(){
		mi_animacion = GetComponent<Animator> (); //animacion palanca
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Space) && dentro){
			activar();
			Invoke("desactivar",tiempo);
		}
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.transform.tag == "Player") {
			dentro = true;
		}
	}


	void OnTriggerExit2D(Collider2D objeto){
		dentro = false;
	}

	void activar(){
		mi_animacion.SetBool ("Activar",true);
	
		Target.SetBool("Activar", true);

	}

	void desactivar(){
		mi_animacion.SetBool ("Activar",false);

		Target.SetBool("Activar", false);
	}
}
