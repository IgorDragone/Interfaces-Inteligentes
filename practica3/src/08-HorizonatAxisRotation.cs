using UnityEngine;

public class HorizonatlAxisRotation : MonoBehaviour {
  public float speed = 2.0f;
  public float rotationSpeed = 100.0f;
  void Update() {
    float horizontalInput = Input.GetAxis("Horizontal");
    transform.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
    transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
  }
}
