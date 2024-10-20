using UnityEngine;
using System.Collections;

public class T2SphereMover : MonoBehaviour {
  public Transform CylinderTarget;

	private void OnEnable() {
		CylinderTrigger.OnColisionWithCube += MoveToObject;
	}

	private void OnDisable() {
		CylinderTrigger.OnColisionWithCube -= MoveToObject;
	}

	private void MoveToObject() {
		StartCoroutine(MoveTowards(CylinderTarget.position));
	}

	private IEnumerator MoveTowards(Vector3 destiny) {
		while (Vector3.Distance(transform.position, destiny) > 0.1f) {
			transform.position = Vector3.MoveTowards(transform.position, destiny, 2f * Time.deltaTime);
			yield return null;
		}
	}
}
