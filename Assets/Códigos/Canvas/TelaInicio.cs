using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicio : MonoBehaviour
{
    public GameObject Itens;
    /*public GameObject TelaConfig;*/

    [HideInInspector]public static bool ursin = false;
    [HideInInspector]public static bool coracao = false;
    [HideInInspector]public static bool bombom = false;
    [HideInInspector]public static bool globo = false;
    [HideInInspector]public static bool pantelone = false;
    [HideInInspector]public static bool bengala = false;
    [HideInInspector]public static bool coolovo = false;
    [HideInInspector]public static bool cueio = false;
    [HideInInspector]public static bool normalovo = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;   
        Cursor.visible = true;
        Itens.SetActive(false);
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
        Itens.SetActive(true);
    }
    public void NaoVerItens()
    {
        Itens.SetActive(false);
    }

}
