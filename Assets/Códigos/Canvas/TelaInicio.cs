using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicio : MonoBehaviour
{ 
    //botões
    public GameObject Iniciar;
    public GameObject Config;
    public GameObject Itens;

    //Titulo
    public GameObject Titulo;

    //Telas
    public GameObject painelItens;
    public GameObject telaC;

    [HideInInspector] public static bool ursin = false;
    [HideInInspector] public static bool coracao = false;
    [HideInInspector] public static bool bombom = false;
    [HideInInspector] public static bool globo = false;
    [HideInInspector] public static bool pantelone = false;
    [HideInInspector] public static bool bengala = false;
    [HideInInspector] public static bool coolovo = false;
    [HideInInspector] public static bool cueio = false;
    [HideInInspector] public static bool normalovo = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        painelItens.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void jogar()
    {
        SceneManager.LoadScene("Dia12");
    }


    public void VerItens()
    {
        painelItens.SetActive(true);

        Iniciar.SetActive(false);
        Config.SetActive(false);
        Itens.SetActive(false);

        Titulo.SetActive(false);
    }
    public void NaoVerItens()
    {
        painelItens.SetActive(false);

        Iniciar.SetActive(true);
        Config.SetActive(true);
        Itens.SetActive(true);

        Titulo.SetActive(true);
    }



    public void abrirC()
    {
        telaC.SetActive(true);

        Iniciar.SetActive(false);
        Config.SetActive(false);
        Itens.SetActive(false);

        Titulo.SetActive(false);
    }
    public void fecharC()
    {
        telaC.SetActive(false);

        Iniciar.SetActive(true);
        Config.SetActive(true);
        Itens.SetActive(true);

        Titulo.SetActive(true);
    }
}
