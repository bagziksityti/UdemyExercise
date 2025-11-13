using UnityEngine;

public class highscore : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    int hit;
    
    
    
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag != "hit")
        {
            hit++;
            Debug.Log("you bumped into thing this many times: " + hit);
        }
            
    }
}
