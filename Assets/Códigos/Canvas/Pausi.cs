using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausi : MonoBehaviour
{
    public GameObject TelaPause;
    public GameObject TextAvanço;
    public dia12 day12;
    public Natal Natal;
    public Pascoa Pasco;

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

        if (day12 != null)
        {

            if (day12.coletou1)
            {
                Avançar();
            }
        }

        if (Pasco != null )
        {
            if (Pasco.coletou1)
            {
                Avançar();
            }
        }

        if (Natal != null) 
        {
            if (Natal.coletou1) 
            {
                Avançar();
            }
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

    void Avançar() 
    {
        TextAvanço.SetActive(true);
    }
    

}
