using UnityEngine;

public class EggTeleporter : MonoBehaviour {
  public GameObject teleportTarget;

	private void OnEnable() {
		CubeProximityEvent.OnCubeApproachesReference += TeleportEgg;
	}

	private void OnDisable() {
		CubeProximityEvent.OnCubeApproachesReference -= TeleportEgg;
	}

	private void TeleportEgg() {
		GetComponent<Rigidbody>().MovePosition(teleportTarget.transform.position);
	}
}
