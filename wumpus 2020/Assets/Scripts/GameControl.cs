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
    private GUI UI;

    private int currentCave;


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
        UI = new GUI();

        currentCave = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentCave = cave.getCave();
    }

    public void getTrivia()
    {

    }

    public void movePlayer()
    {
        int nextRoom = UI.getMovementInput();
        int playerPose = player1.moveRoom(nextRoom);
    }

    public void changeBatPose()
    {
        int newRoom = gameLoc.changeBatRoom();
        UI.moveBat(newRoom);
    }

    public void changeWumpusPose()
    {
        int newRoom = gameLoc.changeWumpusRoom();
        UI.moveWumpus(newRoom);
    }
}
