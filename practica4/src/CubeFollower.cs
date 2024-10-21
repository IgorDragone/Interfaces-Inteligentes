using UnityEngine;

public class CubeFollower : MonoBehaviour {
  public GameObject target;
  public float speed = 1f;

	private void FixedUpdate() {
		Vector3 direction = target.transform.position - transform.position;
		GetComponent<Rigidbody>().MovePosition(transform.position + direction.normalized * speed * Time.fixedDeltaTime);
	}
}
