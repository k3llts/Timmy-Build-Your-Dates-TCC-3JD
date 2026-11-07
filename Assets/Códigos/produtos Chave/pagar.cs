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

    //Entrada dos produtos
    private void OnTriggerEnter(Collider other)
    {
        //Produtos Maravilhosos---------------------------------------
        if (!temProduto && other.CompareTag("Urso")) 
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 100;
            temProduto = true;
            TelaInicio.ursin = true;
        }
        else if (!temProduto && other.CompareTag("Globo"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 100;
            temProduto = true;
            TelaInicio.globo = true;
        }
        else if (!temProduto && other.CompareTag("CoolOvo"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 100;
            temProduto = true;
            TelaInicio.coolovo = true;
        }

        //Produtos bom---------------------------------------
        else if (!temProduto && other.CompareTag("Cueio"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 50;
            temProduto = true;
            TelaInicio.cueio = true;
        }
        else if (!temProduto && other.CompareTag("Pantelone"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 50;
            temProduto = true;
            TelaInicio.pantelone = true;
        }
        else if (!temProduto && other.CompareTag("Corapeito"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 50;
            temProduto = true;
            TelaInicio.coracao = true;
        }

        //Produtos Ruim---------------------------------------
        else if (!temProduto && other.CompareTag("NormalOvo"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 10;
            temProduto = true;
            TelaInicio.normalovo = true;
        }
        else if (!temProduto && other.CompareTag("MeiBom"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 10;
            temProduto = true;
            TelaInicio.bombom = true;
        }
        else if (!temProduto && other.CompareTag("Bengala"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 10;
            temProduto = true;
            TelaInicio.bengala = true;
        }
    }




    //Saida dos produtos
    private void OnTriggerExit(Collider other)
    {
        //Produtos Maravilhosos---------------------------------------
        if (temProduto && other.CompareTag("Urso"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 100;
            temProduto = false;
            TelaInicio.ursin = false;
        }
        else if (temProduto && other.CompareTag("Globo"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 100;
            temProduto = false;
            TelaInicio.globo = false;
        }
        else if (temProduto && other.CompareTag("CoolOvo"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 100;
            temProduto = false;
            TelaInicio.coolovo = false;
        }

        //Produtos bom---------------------------------------
        else if (temProduto && other.CompareTag("Cueio"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 50;
            temProduto = false;
            TelaInicio.cueio = false;
        }
        else if (temProduto && other.CompareTag("Corapeito"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 50;
            temProduto = false;
            TelaInicio.coracao = false;
        }
        else if (temProduto && other.CompareTag("Pantelone"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 50;
            temProduto = false;
            TelaInicio.pantelone = false;
        }

        //Produtos Ruim---------------------------------------
        else if (temProduto && other.CompareTag("NormalOvo"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 10;
            temProduto = false;
            TelaInicio.normalovo = false;
        }
        else if (temProduto && other.CompareTag("Bengala"))
        {   
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 10;
            temProduto = false;
            TelaInicio.bengala = false;
        }
        else if (temProduto && other.CompareTag("MeiBom"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 10;
            temProduto = false;
            TelaInicio.bombom = false;
        }
    }
}
