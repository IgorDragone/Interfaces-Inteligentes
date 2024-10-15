using UnityEngine;

public class CubeMover : MonoBehaviour {
  public float speed = 2.0f;

  void Update() {
    float vertical = Input.GetAxis("Vertical");
    float horizontal = Input.GetAxis("Horizontal");
    Vector3 moveDirection = new Vector3(horizontal, vertical, 0);
    transform.Translate(moveDirection * speed * Time.deltaTime);
  }
}
