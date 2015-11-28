using UnityEngine;
using System.Collections;

public class Ganar : MonoBehaviour {

    //public Animator Target; //Cuando este el personaje

    // Use this for initialization
    void Start(){

    }

    // Update is called once per frame
    void Update(){

    }

    void OnTriggerEnter2D(Collider2D objeto){
        if (objeto.transform.tag == "Ninio"){
            Debug.Log("HAS GANADO!!"); //Quitar cuando este el ninio definitivo

        }
    }
}
