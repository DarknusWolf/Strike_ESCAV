using UnityEngine;
using System.Collections;

public class Camara_Personajes : MonoBehaviour {

    public Transform personaje1, personaje2;
    public float minSizeY = 5f;
    private Camera camara;

    void Awake(){
        camara = GetComponent<Camera>();
    }

    void SetCameraPos(){
        Vector3 middle = (personaje1.position + personaje2.position) * 0.5f;
        camara.transform.position = new Vector3(middle.x, middle.y, camara.transform.position.z);
    }

    void SetCameraSize(){
        //horizontal size is based on actual screen ratio
        float minSizeX = minSizeY * Screen.width / Screen.height;

        //multiplying by 0.5, because the ortographicSize is actually half the height
        float width = Mathf.Abs(personaje1.position.x - personaje2.position.x) * 0.5f;
        float height = Mathf.Abs(personaje1.position.y - personaje2.position.y) * 0.5f;

        //computing the size
        float camSizeX = Mathf.Max(width + 1, minSizeX); //ajuste de zoom
        camara.orthographicSize = Mathf.Max(height, camSizeX * Screen.height / Screen.width, minSizeY);
    }

    void Update(){
        SetCameraPos();
        SetCameraSize();
    }
}
