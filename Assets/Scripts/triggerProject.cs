using UnityEngine;

public class triggerProject : MonoBehaviour
{

    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;
    [SerializeField] GameObject projectile4;
    

    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (projectile1 && projectile2 && projectile3 && projectile4 != null)
        {
            if (other.gameObject.tag == ("Player"))
            {
                projectile1.SetActive(true);
                projectile2.SetActive(true);
                projectile3.SetActive(true);
                projectile4.SetActive(true);
                

            }
        }
    }
}