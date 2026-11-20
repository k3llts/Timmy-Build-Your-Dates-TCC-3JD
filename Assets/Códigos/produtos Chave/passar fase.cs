using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class passarfase : MonoBehaviour
{
    public bool PodeIr = false;
    public static int Pontos = 0;
    public TextMeshProUGUI fimTexto;
    public GameObject textoAvançar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4 && fimTexto != null)
        {
            mensagemFimJogo();
        }
        if (PodeIr) 
        {
            mensagemFimFase();
        }
        if (!PodeIr)
        {
            semMensagemFimFase();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            proximaFase();
        }
    }



    public void voltarInicio()
    {
        SceneManager.LoadScene("TelaInicial");
    }
    void proximaFase()
    {
        if (PodeIr)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("acabou a cena");
        }
    }
    void mensagemFimJogo()
    {
        fimTexto.text = $"Você conseguiu {Pontos} pontos, parabéns";
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void mensagemFimFase()
    {
        textoAvançar.SetActive(true);
    }
    void semMensagemFimFase() 
    {
        textoAvançar.SetActive(false);
    }
}
