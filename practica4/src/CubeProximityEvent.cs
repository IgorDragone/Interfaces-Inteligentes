using UnityEngine;

public class CubeProximityEvent : MonoBehaviour {
  public delegate void CubeApproachAction();
  public static event CubeApproachAction OnCubeApproachesReference;
  public GameObject referenceObject;
  public float proximityDistance = 5.0f;
	private bool isApproaching = false;
  void Update() {
    if (Vector3.Distance(transform.position, referenceObject.transform.position) < proximityDistance) {
			if (!isApproaching) {
				isApproaching = true;
				OnCubeApproachesReference();
			}
		} else {
			isApproaching = false;
		}
  }
}
