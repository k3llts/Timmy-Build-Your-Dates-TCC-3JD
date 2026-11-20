using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausi : MonoBehaviour
{
    public GameObject telaDePause;
    
    public bool pausado = false;
    public GameObject configTela;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        telaDePause.SetActive(false);
        Time.timeScale = 1.0f;
        pausado = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado == false)
            { 
                Pausar();
                Debug.Log("Pauso legal");
            }
            else if (pausado == true)
            {
                Despausar();
                Debug.Log("Despauso legal");
            }
        }
    }


    public void Pausar() 
    {
        telaDePause.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        pausado = true;
    }
    public void Despausar()
    {
        telaDePause.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pausado = false;
        configTela.SetActive(false);
    }
    
    
    public void Inicio()
    {
        SceneManager.LoadScene("TelaInicial");
    }

    

}
