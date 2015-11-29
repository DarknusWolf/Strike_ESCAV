using UnityEngine;
using System.Collections;

public class Puerta_Meta : MonoBehaviour {

    public string Nombre_Sig_nivel;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D objeto){
        if (objeto.transform.tag == "Ninio"){
            Application.LoadLevel(Nombre_Sig_nivel);
        }
    }

}
