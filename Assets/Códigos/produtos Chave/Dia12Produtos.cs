using UnityEngine;
using UnityEngine.SceneManagement;

public class dia12 : MonoBehaviour
{
    public bool coletou1 = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            if (coletou1) 
            {
                SceneManager.LoadScene("Pascoa");
            }
        }
    }

}
