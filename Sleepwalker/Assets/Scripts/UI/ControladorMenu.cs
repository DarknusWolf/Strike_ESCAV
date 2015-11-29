using UnityEngine;
using System.Collections;

public class ControladorMenu : MonoBehaviour {

    private Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
    }

    public void muestra_menu(){
        Time.timeScale = 0;
        anim.SetBool("MuestraMenu", true);
    }
}
