using UnityEngine;

public class time : MonoBehaviour
{
    [SerializeField]float timetoWait = 2f;
    Rigidbody myrigidbody;
    MeshRenderer mymeshRenderer;
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody>();

        mymeshRenderer = GetComponent<MeshRenderer>();
        mymeshRenderer.enabled = false;

    }

    void Update()
    {
        if(Time.time >= timetoWait)
        {
           myrigidbody.useGravity = true;
              mymeshRenderer.enabled = true;
        }
    }
}
