using UnityEngine;


public class pagar : MonoBehaviour
{
    public GameObject Mensagen;
    public passarfase passar;
    private bool temProduto = false;

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
        if (other.CompareTag("Melhor") && !temProduto) 
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 100;
            temProduto = true;
            Debug.Log("Passou presente de 100");
        }

        if (other.CompareTag("Médio") && !temProduto)
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 50;
            temProduto = true;
        }

        if (other.CompareTag("Ruim") && !temProduto)
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 10;
            temProduto = true;
        }



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Melhor") && temProduto)
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 100;
            temProduto = false;
            Debug.Log("saiu presente de 100");
            
        }

        if (other.CompareTag("Médio") && temProduto)
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 50;
            temProduto = false;
        }

        if (other.CompareTag("Ruim") && temProduto)
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 10;
            temProduto = false;
        }

    }
}
