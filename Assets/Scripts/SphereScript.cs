using TMPro;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public float Speed = 10f;
    public float score = 0;
    public TextMeshProUGUI points;
    public GameObject winPanel;
    public TextMeshProUGUI won;
    public timeScript instance;
   
    void Start()
    {
      winPanel.SetActive(false);
      instance = FindObjectOfType<timeScript>();
    }

    void Update()
    {
        Vector3 pos = transform.position;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        pos.x -= v * Speed * Time.deltaTime;
        pos.z += h * Speed * Time.deltaTime;
        transform.position = pos;


        //if(Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.position += new Vector3(0, 0, 1 * Speed * Time.deltaTime);

        //}
        gameWin();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("Collision with " + collision.gameObject.name);
        //score++;
        //Debug.Log(score);
        if (collision.transform.tag == "Coins")
        { 
            score++;
            points.text = score.ToString();
            Destroy(collision.gameObject);
           
        }
        //    Debug.Log(score);    
        //}
        //if(collision.transform.tag == "Coins")
        //{
        //    Debug.Log(score);    
        //}
    }

    public void gameWin()
    {
        if(score == 11)
        {
           // instance.timerOn = false;
            timeScript.timerOn = false; 
          //Debug.Log(instance.timerOn);
            winPanel.SetActive(true);
            won.text = ("You're Won");
        }
    }

      //private void OnTriggerEnter(Collider other)
    //{
    //    if (collision.transform.tag == "Coins")
    //    {
    //        score++;
    //        points.text = score.ToString();
    //        Destroy(collision.gameObject);

    //    }
    //}

}
