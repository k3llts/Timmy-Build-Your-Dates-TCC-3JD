using UnityEngine;

public class pagar : MonoBehaviour
{
    public GameObject Mensagen;
    public passarfase passar;

    // 'static' faz todas as hitboxes dividirem a mesma trava e o mesmo produto
    private static bool temProduto = false;
    private static Collider produtoAtual = null;

    void Start()
    {
        // Garante que a trava comece limpa quando a fase carregar
        temProduto = false;
        produtoAtual = null;
    }

    //Entrada dos produtos
    private void OnTriggerEnter(Collider other)
    {
        // Se já tem um produto em qualquer hitbox, ignora totalmente
        if (temProduto) return;

        //Produtos Maravilhosos---------------------------------------
        if (other.CompareTag("Urso"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 100;
            temProduto = true;
            produtoAtual = other; // Salva quem entrou
            TelaInicio.ursin = true;
        }
        else if (other.CompareTag("Globo"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 100;
            temProduto = true;
            produtoAtual = other;
            TelaInicio.globo = true;
        }
        else if (other.CompareTag("CoolOvo"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 100;
            temProduto = true;
            produtoAtual = other;
            TelaInicio.coolovo = true;
        }

        //Produtos bom---------------------------------------
        else if (other.CompareTag("Cueio"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 50;
            temProduto = true;
            produtoAtual = other;
            TelaInicio.cueio = true;
        }
        else if (other.CompareTag("Pantelone"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 50;
            temProduto = true;
            produtoAtual = other;
            TelaInicio.pantelone = true;
        }
        else if (other.CompareTag("Corapeito"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 50;
            temProduto = true;
            produtoAtual = other;
            TelaInicio.coracao = true;
        }

        //Produtos Ruim---------------------------------------
        else if (other.CompareTag("NormalOvo"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 10;
            temProduto = true;
            produtoAtual = other;
            TelaInicio.normalovo = true;
        }
        else if (other.CompareTag("MeiBom"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 10;
            temProduto = true;
            produtoAtual = other;
            TelaInicio.bombom = true;
        }
        else if (other.CompareTag("Bengala"))
        {
            Mensagen.SetActive(true);
            passar.PodeIr = true;
            passarfase.Pontos = passarfase.Pontos + 10;
            temProduto = true;
            produtoAtual = other;
            TelaInicio.bengala = true;
        }
    }

    //Saida dos produtos
    private void OnTriggerExit(Collider other)
    {
        // Só executa se quem saiu for EXATAMENTE o produto que estava travando
        if (!temProduto || other != produtoAtual) return;

        //Produtos Maravilhosos---------------------------------------
        if (other.CompareTag("Urso"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 100;
            temProduto = false;
            produtoAtual = null; // Libera a trava
            TelaInicio.ursin = false;
        }
        else if (other.CompareTag("Globo"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 100;
            temProduto = false;
            produtoAtual = null;
            TelaInicio.globo = false;
        }
        else if (other.CompareTag("CoolOvo"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 100;
            temProduto = false;
            produtoAtual = null;
            TelaInicio.coolovo = false;
        }

        //Produtos bom---------------------------------------
        else if (other.CompareTag("Cueio"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 50;
            temProduto = false;
            produtoAtual = null;
            TelaInicio.cueio = false;
        }
        else if (other.CompareTag("Corapeito"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 50;
            temProduto = false;
            produtoAtual = null;
            TelaInicio.coracao = false;
        }
        else if (other.CompareTag("Pantelone"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 50;
            temProduto = false;
            produtoAtual = null;
            TelaInicio.pantelone = false;
        }

        //Produtos Ruim---------------------------------------
        else if (other.CompareTag("NormalOvo"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 10;
            temProduto = false;
            produtoAtual = null;
            TelaInicio.normalovo = false;
        }
        else if (other.CompareTag("Bengala"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 10;
            temProduto = false;
            produtoAtual = null;
            TelaInicio.bengala = false;
        }
        else if (other.CompareTag("MeiBom"))
        {
            Mensagen.SetActive(false);
            passar.PodeIr = false;
            passarfase.Pontos = passarfase.Pontos - 10;
            temProduto = false;
            produtoAtual = null;
            TelaInicio.bombom = false;
        }
    }
}
