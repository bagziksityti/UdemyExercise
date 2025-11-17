using UnityEngine;

public class flyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }


    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.transform.position;
        MoveToPlayer();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
        DestroyWhenReached();  

    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition) {
        Destroy(gameObject);
    }
    }
}
