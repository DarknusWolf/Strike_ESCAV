using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    public void reintentar(){
        Application.LoadLevel("Fase1"); //Cargar el nivel en el Building Setting
    }

    public void volver_menu(){
        Application.LoadLevel("Menuinicio");
    }

    /*public void salir(){
        Application.Quit();
    }*/
}
