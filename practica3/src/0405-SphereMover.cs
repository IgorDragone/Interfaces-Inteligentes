using UnityEngine;

public class SphereMover : MonoBehaviour {
  public float speed = 2.0f;

  void Update() {
    float vertical = 0f;
    float horizontal = 0f;
    if (Input.GetKey(KeyCode.W)) {
      vertical = 1;
    } else if (Input.GetKey(KeyCode.S)){
      vertical = -1;
    }
    if (Input.GetKey(KeyCode.A)) {
      horizontal = -1;
    } else if (Input.GetKey(KeyCode.D)) {
      horizontal = 1;
    }
    Vector3 moveDirection = new Vector3(horizontal, vertical, 0);
    transform.Translate(moveDirection * speed * Time.deltaTime);
  }
}
