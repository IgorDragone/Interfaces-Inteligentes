using UnityEngine;

public class CubeMover : MonoBehaviour {
  public Vector3 moveDirection = new Vector3(1, 0, 0);
  public float speed = 2.0f;

  void Start() {
    Vector3 startPosition = transform.position;
    startPosition.y = 0;
    transform.position = startPosition;
  }

  void Update() {
    transform.Translate(moveDirection * speed, Space.Self);
  }
}
