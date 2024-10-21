using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	public delegate void PlayerDamaged();
	public static event PlayerDamaged OnPlayerDamaged;

	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag("T2Spider")) {
			Debug.Log("Player damaged");
			OnPlayerDamaged?.Invoke();
		}
	}

}
