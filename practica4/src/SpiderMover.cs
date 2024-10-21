using UnityEngine;
using System.Collections;

public class SpiderMover : MonoBehaviour {
	public GameObject ReferenceObject;
	private bool shouldMove = false;

	void OnEnable() {
		CubeProximityEvent.OnCubeApproachesReference += MoveToEgg;
	}

	void OnDisable() {
		CubeProximityEvent.OnCubeApproachesReference -= MoveToEgg;
	}

	private void MoveToEgg() {
		shouldMove = true;
	}

	private void FixedUpdate() {
		if (shouldMove && ReferenceObject != null) {
			MoveTowards(ReferenceObject);
		}
	}

	private void MoveTowards(GameObject target) {
		float step = 2f * Time.fixedDeltaTime; 
    GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, target.transform.position, step));
    if (Vector3.Distance(transform.position, target.transform.position) < 0.1f) {
      shouldMove = false;
    }
	}
}
