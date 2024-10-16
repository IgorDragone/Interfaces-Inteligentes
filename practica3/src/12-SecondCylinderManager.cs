using UnityEngine;

public class SecondCylinderManager : MonoBehaviour {
  public float speed = 1f; 
  private Rigidbody rb;

  void Start() {
    rb = GetComponent<Rigidbody>();
  }

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
    Vector3 moveDirection = new Vector3(horizontal, 0, vertical);
    GetComponent<Rigidbody>().AddForce(moveDirection * speed);
  }
}
