using UnityEngine;

public class TriggerDetector : MonoBehaviour {
  private void OnTriggerEnter(Collider other) {
    Debug.Log("Triggered by: " + other.gameObject.tag);
  }
}
