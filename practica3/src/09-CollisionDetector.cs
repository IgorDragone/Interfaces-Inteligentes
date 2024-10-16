using UnityEngine;

public class CollisionDetector : MonoBehaviour {
  private void OnCollisionEnter(Collision collision) {
    Debug.Log("Collision with: " + collision.gameObject.tag);
  }
}
