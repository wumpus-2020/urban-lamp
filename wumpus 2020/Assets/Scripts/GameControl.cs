using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    private Trivia trivia;
    private Cave cave;
    private Player player1;
    private GameLocation gameLoc;
    private HighScore highScore;


    public enum GameState
    {
        PRETURN, PLAYERTURN, POSTTURN
    }

    public enum PlayerState
    {
        PLAYING, DEAD
    }

    // Start is called before the first frame update
    void Start()
    {
        trivia = new Trivia();
        cave = new Cave();
        player1 = new Player();
        gameLoc = new GameLocation();
        highScore = new HighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void getTrivia()
    {

    }

    public void movePlayer()
    {

    }

    public void changeBatPose()
    {

    }

    public void changeWumpusPose()
    {

    }

    public void getCoins()
    {

    }

    public void getArrows()
    {

    }
}
