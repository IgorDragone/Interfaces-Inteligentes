using UnityEngine;
using System.Collections;

public class T1Spider : MonoBehaviour {
  public GameObject T1EggTarget;
	public GameObject T2EggTarget;

	private void OnEnable() {
		Cube.OnCollisionWithT1Spider += MoveToT1Egg;
		Cube.OnCollisionWithT2Spider += MoveToT2Egg;
	}

	private void OnDisable() {
		Cube.OnCollisionWithT1Spider -= MoveToT1Egg;
		Cube.OnCollisionWithT2Spider -= MoveToT2Egg;
	}

	private void MoveToT1Egg() {
		StartCoroutine(MoveTowards(T1EggTarget));
	}

	private void MoveToT2Egg() {
		StartCoroutine(MoveTowards(T2EggTarget));
	}

	private IEnumerator MoveTowards(GameObject target) {
		while (Vector3.Distance(transform.position, target.transform.position) > 0.1f) {
			GetComponent<Rigidbody>().MovePosition(Vector3.MoveTowards(transform.position, target.transform.position, 2f * Time.deltaTime));
			//transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 2f * Time.deltaTime);
			yield return null;
		}
	}

	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag("T2Egg")) {
			GetComponentInChildren<SkinnedMeshRenderer>().material.color = Color.red;
			GetComponentInChildren<Renderer>().material.color = Color.red;
		}
	}
}
