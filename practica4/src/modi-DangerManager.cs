using UnityEngine;
using TMPro;

public class DangerManager : MonoBehaviour {
  [SerializeField] private TextMeshProUGUI dangerText;

	private void OnEnable() {
		CubeProximityEvent.OnCubeApproachesReference += UpdateDanger;
	}

	private void OnDisable() {
		CubeProximityEvent.OnCubeApproachesReference -= UpdateDanger;
	}

	private void UpdateDanger() {
		dangerText.text = "Danger!";
		dangerText.color = Color.red;
	}
}
