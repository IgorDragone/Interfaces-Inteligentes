using UnityEngine;

public class SphereFollower : MonoBehaviour {
  public Transform esfera;
	public float speed = 2.0f;
  void Update() {
    Vector3 direction = esfera.position - transform.position;
    direction.y = 0;
    Vector3 moveDirection = direction.normalized;
    transform.Translate(moveDirection * speed * Time.deltaTime);
  }
}
