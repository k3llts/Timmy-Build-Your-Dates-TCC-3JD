using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class passarfase : MonoBehaviour
{
    public bool PodeIr = false;
    public static int Pontos = 0;
    public TextMeshProUGUI FimTexto;
    public GameObject HitPagar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4 && FimTexto != null)
        {
            FimTexto.text = $"Você conseguiu {Pontos} pontos, parabéns";
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && PodeIr) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Destroy(HitPagar);
            Debug.Log("acabou a cena");
        }
    }
    public void Inicio()
    {
        SceneManager.LoadScene("TelaInicial");
    }
}
