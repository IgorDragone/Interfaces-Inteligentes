using UnityEngine;

public class SpherePosition : MonoBehaviour {
  private Vector3 spherePosition;
  void Update() {
    spherePosition = transform.position;
  }
  void OnGUI() {
    GUI.Label(new Rect(10, 10, 300, 20), "Posición de la esfera: " + spherePosition.ToString()); // Rect(x, y, width, height)
  }
}
