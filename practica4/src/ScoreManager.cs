using UnityEngine;

public class ScoreManager : MonoBehaviour {
  private int playerScore = 0;
  private void OnEnable() {
    EggCollecting.OnEggCollected += UpdateScore;
  }

  private void OnDisable() {
    EggCollecting.OnEggCollected -= UpdateScore;
  }

  private void UpdateScore(int points) {
    playerScore += points;
		UpdateScoreUI();
    // Debug.Log("Player Score: " + playerScore);
  }

	private void UpdateScoreUI() {
		scoreText.text = "Score: " + playerScore.ToString();
	}
}
