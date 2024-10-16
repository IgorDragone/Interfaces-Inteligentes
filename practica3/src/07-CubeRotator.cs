using UnityEngine;

public class CubeRotator : MonoBehaviour {
  public Transform esfera;
  public float speed = 2.0f;

  void Update() {
    Vector3 targetPosition = esfera.position;
    targetPosition.y = transform.position.y;
    transform.LookAt(targetPosition);
		Vector3 moveDirection = transform.forward;
    transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
  }
}
