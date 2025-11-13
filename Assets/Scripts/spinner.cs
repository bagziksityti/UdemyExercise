using UnityEngine;

public class spinner : MonoBehaviour
{
    [SerializeField] float x = 0f;
    [SerializeField] float y = 1f;
    [SerializeField] float z = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x,y,z);
    }
}
