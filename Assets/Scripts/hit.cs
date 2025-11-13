using Unity.Cinemachine;
using UnityEngine;

public class hit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision detected with " + collision.gameObject.name);
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "hit";
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
