using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public bool IJ;
    public bool MJ;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite oldSprite;
    public int i,score;
    public static bool gameOver;
    public GameObject gameOverText;
    public GameObject gameOverLine;
    public Button pauseButton;
    public Button playButton;
    public Button replayButton;
    public GameObject pauseButtonG;
    public GameObject playButtonG;
    public GameObject replayButtonG;
    public Text scoreText;
    public Text TextBox;
    public Text TextLine;
    public Button nextButton;
    public GameObject next;
    public int highScore;

    void ChangeSprite(bool k)
    {
        if(k==true){
            spriteRenderer.sprite = newSprite;
        }
        else{
            spriteRenderer.sprite = oldSprite;
        }
    }

    void Start()
    {
        Time.timeScale=1;
        IJ=false;
        MJ=false;
        i=0;
        score = 0;
        scoreText.text = "SCORE: "+score.ToString();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        gameOverText.SetActive(false);
        gameOverLine.SetActive(false);
        pauseButtonG.SetActive(true);
        pauseButton.onClick.AddListener(onPause);
        playButtonG.SetActive(false);
        playButton.onClick.AddListener(onPlay);
        replayButtonG.SetActive(false);
        replayButton.onClick.AddListener(onReplay);
        nextButton.onClick.AddListener(nextLevel);
        gameOver=false;
        next.SetActive(false);
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began&& IJ==false){
            GetComponent<Rigidbody2D> ().velocity = new Vector3(0,15,0);
            IJ=true;
        }
        if(i>=18 && !gameOver){
            i=0;
            if(MJ==false){
                ChangeSprite(false);
                MJ=true;
            }
            else{
                MJ=false;
                ChangeSprite(true);
            }
        }
        else{
            i+=1;
        }
        if(!gameOver){
            score+=1;
            if(highScore<=score){
                highScore+=score;
            }
            //highText.text = highScore;
            scoreText.text = "SCORE: "+score.ToString();
        }

        if(score>=3000){
            TextBox.text = "CONGRATS!";
            TextLine.text = "LEVEL 1 PASSED";
            gameOverText.SetActive(true);
            gameOverLine.SetActive(true);
            next.SetActive(true);
            pauseButtonG.SetActive(false);
            gameOver = true;
            Time.timeScale = 0;
        }
        if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("GameIntro");
            }

    }

    void OnCollisionEnter2D(Collision2D Coll){
        if(Coll.gameObject.tag=="Finish"){
            IJ=false;
        }
        if(Coll.gameObject.tag=="Respawn"){
            gameOver=true;
            Time.timeScale=0;
            gameOverText.SetActive(true);
            gameOverLine.SetActive(true);
            replayButtonG.SetActive(true);
            pauseButtonG.SetActive(false);
        }
    }

    void onReplay(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void onPause(){
        gameOver=true;
        playButtonG.SetActive(true);
        pauseButtonG.SetActive(false);
        Time.timeScale=0;
    }

    void onPlay(){
        gameOver=false;
        playButtonG.SetActive(false);
        pauseButtonG.SetActive(true);
        Time.timeScale=1;
    }

    void nextLevel(){
        SceneManager.LoadScene("Level2");
    }

}