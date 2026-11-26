using UnityEngine;

public class abrirConfig : MonoBehaviour
{
    //botões
    public GameObject Retomar;
    public GameObject Config;
    public GameObject Menu;


    public GameObject Dicas;

    public GameObject telaC;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        telaC.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void abrirC()
    {
        telaC.SetActive(true);

        Retomar.SetActive(false);
        Config.SetActive(false);
        Menu.SetActive(false);

        Dicas.SetActive(false);
    }
    public void fecharC()
    {
        telaC.SetActive(false);

        Retomar.SetActive(true);
        Config.SetActive(true);
        Menu.SetActive(true);

        Dicas.SetActive(true);
    }
}
