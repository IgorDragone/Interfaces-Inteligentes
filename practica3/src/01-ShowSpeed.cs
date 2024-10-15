using UnityEngine;

public class ShowSpeed : MonoBehaviour {
  public float velocidad = 5.0f;

  void Update() {
    if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {
      float vertical = Input.GetAxis("Vertical");
      float resultadoVertical = velocidad * vertical;
      if (Input.GetKey(KeyCode.UpArrow)) {
      	Debug.Log("Flecha arriba: " + resultadoVertical);
      } else if (Input.GetKey(KeyCode.DownArrow)) {
        Debug.Log("Flecha abajo: " + resultadoVertical);
      }
    }
    if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
      float horizontal = Input.GetAxis("Horizontal");
      float resultadoHorizontal = velocidad * horizontal;
      if (Input.GetKey(KeyCode.LeftArrow)) {
        Debug.Log("Flecha izquierda: " + resultadoHorizontal);
      } else if (Input.GetKey(KeyCode.RightArrow)) {
        Debug.Log("Flecha derecha: " + resultadoHorizontal);
      }
    }
  }
}
