using UnityEngine;

public class triggerProject : MonoBehaviour
{

    [SerializeField] GameObject[] projectile;
    void Start()
    {
        projectile = new GameObject[4];
        for (int i = 0; i < projectile.Length; i++)
        {
            projectile[i] = new GameObject;

        }
    }
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == ("Player"))

        {
            for (int i = 0; i < projectile.Length; i++)
            {
                if (projectile[i] != null)
                {
                    projectile[i].SetActive(true);
                }
                if (projectile[i].transform.position == other.transform.position)
                {
                    Destroy(projectile[i]);
                }

            }
        }
    }
}