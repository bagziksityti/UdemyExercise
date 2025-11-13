using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField]float moveSpeed = 10f;



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
        float y = 0f; // Made y serializable to adjust in the Inspector
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x, y, z);
    }
}
