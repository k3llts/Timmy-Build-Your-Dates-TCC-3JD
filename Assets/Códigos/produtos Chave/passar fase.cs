using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class passarfase : MonoBehaviour
{
    public bool PodeIr = false;
    public GameObject textoAvançar;
    public VideoPlayer videoPlayer;
    public GameObject telaDoVideo;


    public static int Pontos = 0;
    public GameObject StrNormal;
    public GameObject StrSorridente;
    public GameObject StrFeliz;
    public TMP_Text Indicar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        telaDoVideo.SetActive(false);
        if (Pontos == 300)
        {
            Indicar.text = "Pontuação perfeita";
        }
        else if (Pontos < 300)
        {
            Indicar.text = "Você pode fazer melhor pelo seu amor!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            FimJogo();
        }

        if (PodeIr) 
        {
            mensagemFimFase();
        }
        else if (!PodeIr)
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

    public void CutsceneFim() 
    {
        if (Pontos == 300) 
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            telaDoVideo.SetActive(true);
            videoPlayer.Play();
        }
        else if (Pontos < 300) 
        {
            voltarInicio();
        }
        Invoke("voltarInicio", 171f);
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
    void FimJogo()
    {
        if (Pontos >= 300 && StrFeliz != null) 
        {
            StrFeliz.SetActive(true);
        }


        if (Pontos >= 110 && StrSorridente != null)
        {
            StrSorridente.SetActive(true);
        }


        if (Pontos >= 10 && StrNormal != null)
        {
            StrNormal.SetActive(true);
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void mensagemFimFase()
    {
        if (textoAvançar != null) 
        { 
            textoAvançar.SetActive(true);
        }
    }
    void semMensagemFimFase() 
    {

        if (textoAvançar != null)
        {
            textoAvançar.SetActive(false);
        }
    }
}
