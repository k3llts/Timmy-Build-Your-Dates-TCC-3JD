using UnityEngine;
using UnityEngine.SceneManagement;


public class passarfase : MonoBehaviour
{
    public bool PodeIr = false;
    public static int Pontos;

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
        if(other.CompareTag("Player") && PodeIr) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
