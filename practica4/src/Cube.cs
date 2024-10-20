using UnityEngine;

public class Cube : MonoBehaviour {
  public delegate void CollisionWithT1SpiderHandler();
  public delegate void CollisionWithT2SpiderHandler();
  public static event CollisionWithT1SpiderHandler OnCollisionWithT1Spider;
  public static event CollisionWithT2SpiderHandler OnCollisionWithT2Spider;
  private void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.CompareTag("T1Spider")) {
      OnCollisionWithT1Spider?.Invoke();
    }
    else if (collision.gameObject.CompareTag("T2Spider")) {
      OnCollisionWithT2Spider?.Invoke();
    }
  }
}
