using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public string sceneToLoad;
     public Text scoreCounter;
    private static GameManager instance;

    public int score;

    public static GameManager Instance {
        get {
            if(instance==null) {
                instance = new GameManager();
            }
 
            return instance;
        }
    }
    
 
    void Awake()
    {
        instance = this;
    }
 
    public void UpdateScore()
    {
        score++;
        scoreCounter.text = "Score: " + score; 
        if(score == 10){
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
