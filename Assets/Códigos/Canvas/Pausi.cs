using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausi : MonoBehaviour
{
    public GameObject TelaPause;
    public GameObject TextAvanço;
    public bool Ativo = false;
    public GameObject configTela;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TelaPause.SetActive(false);
        Time.timeScale = 1.0f;
        Ativo = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Ativo == false)
            { 
                Pausar();
                Debug.Log("Pauso legal");
            }
            else if (Ativo == true)
            {
                Despausar();
                Debug.Log("Despauso legal");
            }
        }
    }


    public void Pausar() 
    {
        TelaPause.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Ativo = true;
    }
    public void Despausar()
    {
        TelaPause.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Ativo = false;
        configTela.SetActive(false);
    }
    
    
    public void Inicio()
    {
        SceneManager.LoadScene("TelaInicial");
    }
    void Avançar() 
    {
        TextAvanço.SetActive(true);
    }
    

}
