using UnityEngine;
using System.Collections;

public class ControladorMenu : MonoBehaviour {

    private Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
    }

    public void muestra_menu(){
        anim.SetBool("MuestraMenu", true);
        Time.timeScale = 0;
    }
}
