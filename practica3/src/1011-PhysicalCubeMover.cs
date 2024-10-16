using UnityEngine;

public class PhysicalCubeMover : MonoBehaviour {
  public float speed = 1.0f;

  void Update() {
    float vertical = Input.GetAxis("Vertical");
    float horizontal = Input.GetAxis("Horizontal");
    Vector3 moveDirection = new Vector3(horizontal, 0, vertical);
    GetComponent<Rigidbody>().AddForce(moveDirection * speed);
  }
}
