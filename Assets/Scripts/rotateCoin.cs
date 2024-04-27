using UnityEngine;

public class rotateCoin : MonoBehaviour
{
    public float speed = 60f;
   

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
