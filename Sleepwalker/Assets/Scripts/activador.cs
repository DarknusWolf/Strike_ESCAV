ausing UnityEngine;
using System.Collections;

public class activador : MonoBehaviour {
	public Animator target;//meter animacion puerta
	bool dentro = false;


	Animator mi_animacion;

	void Start(){
		mi_animacion = GetComponent<Animator> ();//animacion palanca
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Space) && dentro){
			activar();
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
			target.SetBool("activar", true);
		mi_animacion.SetBool ("activar",true);
	}
}
