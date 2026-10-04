using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicio : MonoBehaviour
{
    /*public GameObject TelaCreditos;
    public GameObject TelaConfig;*/


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void jogar() 
    {
        SceneManager.LoadScene("Dia12");
    }

}
