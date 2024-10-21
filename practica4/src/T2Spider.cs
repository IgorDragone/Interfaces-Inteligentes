using UnityEngine;

public class T2Spider : MonoBehaviour {
	public GameObject ReferenceObject;

	void OnEnable() {
		CubeProximityEvent.OnCubeApproachesReference += OrientTowardsTarget;
	}

	void OnDisable() {
		CubeProximityEvent.OnCubeApproachesReference -= OrientTowardsTarget;
	}

	void OrientTowardsTarget() {
		transform.LookAt(ReferenceObject.transform);
	}
}
