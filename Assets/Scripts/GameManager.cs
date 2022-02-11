using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle p1Paddle;
    public Paddle p2Paddle;
    public Text p1ScoreTxt;
    public Text p2ScoreTxt;

    private int p1Score;
    private int p2Score;
    public AudioClip saw;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
    }

    public void PlayerScores()
    {
        p1Score++;
        this.p1ScoreTxt.text = p1Score.ToString();

        if (p1Score == 11)
        {
            this.p1ScoreTxt.text = "P1 WINS!";
            Debug.Log("Game Over. Left Paddle (Player 1) wins.");
            GetComponent<AudioSource>().Play();
            this.ball.ResetPosition();
            StartCoroutine(ExecuteAfterTime(3));
        }

        Debug.Log("Player 1 Scored:" + p2Score);
    }

    public void Player2Scores()
    {
        p2Score++;
        this.p2ScoreTxt.text = p2Score.ToString();

        if (p2Score == 11)
        {
            this.p2ScoreTxt.text = "P2 WINS!";
            Debug.Log("Game Over. Right Paddle (Player 2) wins.");
            GetComponent<AudioSource>().Play();
            this.ball.ResetPosition();
            StartCoroutine(ExecuteAfterTime(3));
        }

        Debug.Log("Player 2 Scored:" + p2Score);
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        this.p1ScoreTxt.text = "0";
        this.p2ScoreTxt.text = "0";
        p1Score = 0;
        p2Score = 0;
        AllReset();
    }

    private void AllReset()
    {
        this.p1Paddle.ResetPosition();
        this.p2Paddle.ResetPosition();
        this.ball.AddStartingForce();
    }
}
