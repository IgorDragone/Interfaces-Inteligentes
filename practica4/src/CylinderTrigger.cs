using UnityEngine;

public class CylinderTrigger : MonoBehaviour
{
  public delegate void CollisionAllert();
  public static event CollisionAllert OnColisionWithCube;
  private void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Cube")) {
      OnColisionWithCube?.Invoke();
    }
  }
}
