using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausi : MonoBehaviour
{
    public GameObject TelaPause;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TelaPause.SetActive(false);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Pausar();
        }
    }

    public void Pausar() 
    {
        TelaPause.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Despausar()
    {
        TelaPause.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Inicio()
    {
        SceneManager.LoadScene("TelaInicial");
    }

}
