using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {
  private int playerScore = 0;
	private int rewardCount = 0;
	private int rewardTreshold = 100;
	
	[SerializeField] private TextMeshProUGUI scoreText;
	[SerializeField] private TextMeshProUGUI rewardPanel;

  private void OnEnable() {
    EggCollecting.OnEggCollected += UpdateScore;
  }

  private void OnDisable() {
    EggCollecting.OnEggCollected -= UpdateScore;
  }

  private void UpdateScore(int points) {
    playerScore += points;
		UpdateScoreUI();
		if (playerScore >= rewardTreshold) {
			GiveReward();
			rewardTreshold += 100;
		}
    // Debug.Log("Player Score: " + playerScore);
  }

	private void UpdateScoreUI() {
		scoreText.text = "Score: " + playerScore.ToString();
	}

	private void GiveReward() {
		rewardCount++;
		rewardPanel.text = "Stars: " + rewardCount.ToString();
	}
}
