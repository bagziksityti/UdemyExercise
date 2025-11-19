using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField]float moveSpeed = 10f;
    [SerializeField] float dify; 



    void Start()
    {
        PrintInstructions();
    }


    void Update()
    {
        
        movePlayer();
         
    }

    void PrintInstructions()
    {

        Debug.Log("Use WASD or Arrow keys to move the object.");

    }
    void movePlayer()
    {

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float y = Input.GetAxis("Jump")*Time.deltaTime*moveSpeed; 
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(x, y*dify, z);

    }
}
