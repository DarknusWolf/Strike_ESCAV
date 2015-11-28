using UnityEngine;
using System.Collections;

public class Despierta : MonoBehaviour {
    
    public Animator Target; //Cuando este el personaje

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D objeto){ 
        if (objeto.transform.tag == "Ninio"){
            Debug.Log("Me Despierto! PERDISTE!!"); //Quitar cuando este el ninio definitivo //OnTriggerEnter2D(Collider2D objeto)
        }
    }
}
