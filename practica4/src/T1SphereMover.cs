using UnityEngine;
using System.Collections;

public class T1SphereMover : MonoBehaviour {
  public GameObject T2SphereTarget;

  private void OnEnable() {
    CylinderTrigger.OnColisionWithCube += MoveToObject;
  }

  private void OnDisable() {
    CylinderTrigger.OnColisionWithCube -= MoveToObject;
  }

  private void MoveToObject() {
    StartCoroutine(MoveTowards(T2SphereTarget));
  }

  private IEnumerator MoveTowards(GameObject target) {
		while (Vector3.Distance(transform.position, target.transform.position) > 0.1f) {
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 2f * Time.deltaTime);
			yield return null;
		}
	}
}
