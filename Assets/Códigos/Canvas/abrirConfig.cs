using UnityEngine;

public class abrirConfig : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject telaC;
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
    }
    public void fecharC()
    {
        telaC.SetActive(false);
    }
}
