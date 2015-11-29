using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    public void fase1(){
        Application.LoadLevel("Fase1"); //Cargar el nivel en el Building Setting
        Time.timeScale = 1;
    }

    public void fase2(){
        Application.LoadLevel("Fase2");
        Time.timeScale = 1;
    }

    public void volver_menu(){
        Application.LoadLevel("Menuentrada");
        Time.timeScale = 1;
    }

    public void salir(){
        Application.Quit();
    }
    
    
}
