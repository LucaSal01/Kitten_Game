using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float Timer;
    public AudioSource theMusic;
    public AudioSource Meow;
    public AudioSource clipMeow;
    public bool startPlaying;
    public NotesScroller notesScroller;
    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 10;
    public int scorePerGoodNote = 50;
    public int scorePerPerfectNote= 100;
    

    public int currentMultiplier;
    public int MultiplierTracker;
    public int[] multiplierTrasholds;

    public Text scoreText;
    public Text multiTex;

    void Start()
    {
        instance = this;
        scoreText.text = "Score : 0";
        currentMultiplier = 1;
    }

    void Update()
    {
        //MusicStart();
        if (!startPlaying)
        {
            if (!Input.anyKeyDown)
            {
                startPlaying = true;
                notesScroller.hasStarted = true;

                theMusic.Play();
                Meow.Play();
            }
        }
    }
    public void MusicStart()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        if (Timer < 0)
        {
            
            Timer = 0;
        }
    }

    public void NotesHit()
    {
        clipMeow.Play();
        if (currentMultiplier - 1 < multiplierTrasholds.Length)
        {

            MultiplierTracker++;

            if (multiplierTrasholds[currentMultiplier - 1] <= MultiplierTracker)
            {
                MultiplierTracker = 0;
                currentMultiplier++;
            }
        }
        multiTex.text = "Multiplier: x" + currentMultiplier;

        scoreText.text = "Score: " + currentScore;
    }
    public void NormalHit()
    {
        currentScore += scorePerNote * currentMultiplier;
        NotesHit();
    }
    public void GoodHit()
    {
        currentScore += scorePerGoodNote * currentMultiplier;
        NotesHit();
    }
    public void PerfectHit()
    {
        currentScore += scorePerPerfectNote * currentMultiplier;
        NotesHit();
    }

    public void NoteMissed()
    {
        Debug.Log("Missed");

        currentMultiplier = 1;
        MultiplierTracker = 0;

        multiTex.text = "Multiplier: x" + currentMultiplier;
    }
}
