using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;

    public Paddle computerPaddle;

    public TextMeshProUGUI playerScoreText;

    public TextMeshProUGUI computerScoreText;

    private int playerScore;

    private int computerScore;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        RoundReset();
    }

    public void ComputerScores()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        RoundReset();
    }

    private void RoundReset()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetBallPosition();
        ball.AddStartForce();
    }
}
