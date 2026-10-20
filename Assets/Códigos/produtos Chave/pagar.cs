using UnityEngine;


public class pagar : MonoBehaviour
{
    public GameObject Mensagen;
    public passarfase passar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Melhor")) 
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos += 100;
        }

        if (other.CompareTag("Médio"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos += 50;
        }

        if (other.CompareTag("Ruim"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos += 10;
        }



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Melhor"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos -= 100;
        }

        if (other.CompareTag("Médio"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos -= 50;
        }

        if (other.CompareTag("Ruim"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos -= 10;
        }

    }
}
