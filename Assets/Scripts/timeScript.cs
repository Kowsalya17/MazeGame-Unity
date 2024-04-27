
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timeScript : MonoBehaviour
{
    public float timeLeft;
    public static bool timerOn = false;
    public TextMeshProUGUI timerTxt;
    public GameObject panel;
    public TextMeshProUGUI scoreText;
    private SphereScript scriptInstance;
        

    void Start()
    {
        panel.SetActive(false);
        timerOn = true;
        scriptInstance = FindObjectOfType<SphereScript>();
    }

    void Update()
    {
        if(timerOn)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                panel.SetActive(true);
                float scores = scriptInstance.score;
                scoreText.text = ("Your Score is : " + scores.ToString());
                timeLeft = 0;
                timerOn = false;
            }
        }
    }

    void updateTimer(float currenttime)
    {
        //add 1 to increase the value to 1 as it display in order by 60
           currenttime = currenttime + 1;
        //float minutes = Mathf.FloorToInt(currenttime / 60);
        float seconds = Mathf.FloorToInt(currenttime %  60);
        timerTxt.text = string.Format("{0:00}",  seconds);
    }

    public void Restart()
    {
        SceneManager.LoadScene("MazeGame");
    }

  }
