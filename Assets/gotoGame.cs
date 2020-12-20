using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gotoGame : MonoBehaviour
{

    public Button playButton;
    public Button profileButton;
    public Button planstButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(clickPlay);
        profileButton.onClick.AddListener(clickProfile);
        planstButton.onClick.AddListener(clickPlanst);
        Screen.orientation = ScreenOrientation.LandscapeRight;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void clickPlay(){
        SceneManager.LoadScene("StartGame");
    }

    void clickPlanst(){
        SceneManager.LoadScene("Planstagram");
    }

    void clickProfile(){
        SceneManager.LoadScene("Profile");
    }


}
