using UnityEngine;

public class SpiderMover : MonoBehaviour {
  public GameObject egg;
	public float speed = 2.0f;
	bool shouldMove = false;
	private void OnEnable() {
		CubeProximityEvent.OnCubeApproachesReference += MoveToEgg;
	}

	private void OnDisable() {
		CubeProximityEvent.OnCubeApproachesReference -= MoveToEgg;
	}

	private void MoveToEgg() {
		shouldMove = true;
	}

	private void FixedUpdate() {
		if (shouldMove && egg != null) {
			MoveTowards(egg);
		}
	}

	private void MoveTowards(GameObject target) {
		float step = speed * Time.fixedDeltaTime;
		GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, target.transform.position, step));
		if (Vector3.Distance(transform.position, target.transform.position) < 0.1f) {
			shouldMove = false;
		}
	}
}
