using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	public TextMeshProUGUI scoreText;
	public GameObject GameOverPanel;
	
	int score = 0;

	bool gameOver = false;

	private void Awake()
	{
		instance = this;
		
	}
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}


	public void GameOver()
	{
		gameOver = true;
		GameOverPanel.SetActive(true);

		GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();

	}

	public void IncrementScore()
	{
		if (!gameOver)
		{
			score++;
			scoreText.text = score.ToString();
			Debug.Log(score);
		}
	}
}
