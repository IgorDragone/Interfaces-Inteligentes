using UnityEngine;

public class T1SpiderTeleport : MonoBehaviour {
	public GameObject EggTarget;

	void OnEnable() {
		CubeProximityEvent.OnCubeApproachesReference += TeleportToEgg;
	}

	void OnDisable() {
		CubeProximityEvent.OnCubeApproachesReference -= TeleportToEgg;
	}

	void TeleportToEgg() {
		GetComponent<Rigidbody>().MovePosition(EggTarget.transform.position);
	}
}
