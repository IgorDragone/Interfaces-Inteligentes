using UnityEngine;
using TMPro;

public class LifeBarManager : MonoBehaviour {
  private int playerLife = 100;
  private int damage = 10;
  [SerializeField] private TextMeshProUGUI lifeText;

  private void OnEnable() {
    PlayerHealth.OnPlayerDamaged += UpdateLife;
  }

  private void OnDisable() {
    PlayerHealth.OnPlayerDamaged -= UpdateLife;
  }

	private void UpdateLife() {
		playerLife -= damage;
		UpdateLifeUI();
		if (playerLife <= 0) {
			lifeText.text = "Game Over";
			Time.timeScale = 0;
		}
	}

	private void UpdateLifeUI() {
		lifeText.text = "Life: " + playerLife.ToString();
	}
}
