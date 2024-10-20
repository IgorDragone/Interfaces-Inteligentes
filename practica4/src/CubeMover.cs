using UnityEngine;

public class CubeMover : MonoBehaviour {
  public float speed = 5f;

  private void Update() {
    float vertical = Input.GetAxis("Vertical");
    float horizontal = Input.GetAxis("Horizontal");
    Vector3 movement = new Vector3(horizontal, 0, vertical);
    transform.Translate(movement * speed * Time.deltaTime);
  }
}
