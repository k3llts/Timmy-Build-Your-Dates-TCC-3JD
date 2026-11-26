using UnityEngine;

public class pagar : MonoBehaviour
{
    public passarfase passar;
    public static bool temProduto = false;
    public static Collider produtoAtual = null;

    void Start()
    {
        temProduto = false;
        produtoAtual = null;
    }

    // Entrada dos produtos
    private void OnTriggerEnter(Collider other)
    {
        // Se algum presente passou em qualquer hitbox todas fecham para os outros
        if (temProduto) return;

        // Produtos Maravilhosos---------------------------------------
        if (other.CompareTag("Urso"))
        {
            EntrarUrso(other);
        }
        else if (other.CompareTag("Globo"))
        {
            EntrarGlobo(other);
        }
        else if (other.CompareTag("CoolOvo"))
        {
            EntrarCoolOvo(other);
        }
        // Produtos bom---------------------------------------
        else if (other.CompareTag("Cueio"))
        {
            EntrarCueio(other);
        }
        else if (other.CompareTag("Pantelone"))
        {
            EntrarPantelone(other);
        }
        else if (other.CompareTag("Corapeito"))
        {
            EntrarCorapeito(other);
        }
        // Produtos Ruim---------------------------------------
        else if (other.CompareTag("NormalOvo"))
        {
            EntrarNormalOvo(other);
        }
        else if (other.CompareTag("MeiBom"))
        {
            EntrarMeiBom(other);
        }
        else if (other.CompareTag("Bengala"))
        {
            EntrarBengala(other);
        }
    }



    private void EntrarUrso(Collider other)
    {
        TelaInicio.ursin = true;
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 100;
        temProduto = true;
        produtoAtual = other; // salva qual entrou
    }

    private void EntrarGlobo(Collider other)
    {
        TelaInicio.globo = true;
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 100;
        temProduto = true;
        produtoAtual = other;
    }

    private void EntrarCoolOvo(Collider other)
    {
        TelaInicio.coolovo = true;
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 100;
        temProduto = true;
        produtoAtual = other;
    }

    private void EntrarCueio(Collider other)
    {
        TelaInicio.cueio = true;
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 50;
        temProduto = true;
        produtoAtual = other;
    }

    private void EntrarPantelone(Collider other)
    {
        TelaInicio.pantelone = true;
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 50;
        temProduto = true;
        produtoAtual = other;
    }

    private void EntrarCorapeito(Collider other)
    {
        TelaInicio.coracao = true;
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 50;
        temProduto = true;
        produtoAtual = other;
    }

    private void EntrarNormalOvo(Collider other)
    {
        TelaInicio.normalovo = true;
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 10;
        temProduto = true;
        produtoAtual = other;
    }

    private void EntrarMeiBom(Collider other)
    {
        TelaInicio.bombom = true;
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 10;
        temProduto = true;
        produtoAtual = other;
    }

    private void EntrarBengala(Collider other)
    {
        TelaInicio.bengala = true;
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 10;
        temProduto = true;
        produtoAtual = other;
    }







    private void OnTriggerExit(Collider other)
    {
        // Só executa se quem saiu for EXATAMENTE o produto que estava travando
        if (!pagar.temProduto || other != pagar.produtoAtual) return;

        // Produtos Maravilhosos---------------------------------------
        if (other.CompareTag("Urso"))
        {
            SaiuUrso();
        }
        else if (other.CompareTag("Globo"))
        {
            SaiuGlobo();
        }
        else if (other.CompareTag("CoolOvo"))
        {
            SaiuCoolOvo();
        }
        // Produtos bom---------------------------------------
        else if (other.CompareTag("Cueio"))
        {
            SaiuCueio();
        }
        else if (other.CompareTag("Corapeito"))
        {
            SaiuCorapeito();
        }
        else if (other.CompareTag("Pantelone"))
        {
            SaiuPantelone();
        }
        // Produtos Ruim---------------------------------------
        else if (other.CompareTag("NormalOvo"))
        {
            SaiuNormalOvo();
        }
        else if (other.CompareTag("Bengala"))
        {
            SaiuBengala();
        }
        else if (other.CompareTag("MeiBom"))
        {
            SaiuMeiBom();
        }
    }

    private void SaiuUrso()
    {
        TelaInicio.ursin = false;
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 100;
        pagar.temProduto = false;
        pagar.produtoAtual = null; // Libera a trava
    }

    private void SaiuGlobo()
    {
        TelaInicio.globo = false;
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 100;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
    }

    private void SaiuCoolOvo()
    {
        TelaInicio.coolovo = false;
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 100;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
    }

    private void SaiuCueio()
    {
        TelaInicio.cueio = false;
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 50;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
    }

    private void SaiuCorapeito()
    {
        TelaInicio.coracao = false;
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 50;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
    }

    private void SaiuPantelone()
    {
        TelaInicio.pantelone = false;
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 50;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
    }

    private void SaiuNormalOvo()
    {
        TelaInicio.normalovo = false;
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 10;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
    }

    private void SaiuBengala()
    {
        TelaInicio.bengala = false;
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 10;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
    }

    private void SaiuMeiBom()
    {
        TelaInicio.bombom = false;
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 10;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
    }

}
