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
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 100;
        temProduto = true;
        produtoAtual = other; // salva qual entrou
        TelaInicio.ursin = true;
    }

    private void EntrarGlobo(Collider other)
    {
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 100;
        temProduto = true;
        produtoAtual = other;
        TelaInicio.globo = true;
    }

    private void EntrarCoolOvo(Collider other)
    {
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 100;
        temProduto = true;
        produtoAtual = other;
        TelaInicio.coolovo = true;
    }

    private void EntrarCueio(Collider other)
    {
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 50;
        temProduto = true;
        produtoAtual = other;
        TelaInicio.cueio = true;
    }

    private void EntrarPantelone(Collider other)
    {
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 50;
        temProduto = true;
        produtoAtual = other;
        TelaInicio.pantelone = true;
    }

    private void EntrarCorapeito(Collider other)
    {
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 50;
        temProduto = true;
        produtoAtual = other;
        TelaInicio.coracao = true;
    }

    private void EntrarNormalOvo(Collider other)
    {
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 10;
        temProduto = true;
        produtoAtual = other;
        TelaInicio.normalovo = true;
    }

    private void EntrarMeiBom(Collider other)
    {
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 10;
        temProduto = true;
        produtoAtual = other;
        TelaInicio.bombom = true;
    }

    private void EntrarBengala(Collider other)
    {
        passar.PodeIr = true;
        passarfase.Pontos = passarfase.Pontos + 10;
        temProduto = true;
        produtoAtual = other;
        TelaInicio.bengala = true;
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
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 100;
        pagar.temProduto = false;
        pagar.produtoAtual = null; // Libera a trava
        TelaInicio.ursin = false;
    }

    private void SaiuGlobo()
    {
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 100;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
        TelaInicio.globo = false;
    }

    private void SaiuCoolOvo()
    {
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 100;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
        TelaInicio.coolovo = false;
    }

    private void SaiuCueio()
    {
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 50;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
        TelaInicio.cueio = false;
    }

    private void SaiuCorapeito()
    {
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 50;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
        TelaInicio.coracao = false;
    }

    private void SaiuPantelone()
    {
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 50;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
        TelaInicio.pantelone = false;
    }

    private void SaiuNormalOvo()
    {
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 10;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
        TelaInicio.normalovo = false;
    }

    private void SaiuBengala()
    {
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 10;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
        TelaInicio.bengala = false;
    }

    private void SaiuMeiBom()
    {
        passar.PodeIr = false;
        passarfase.Pontos = passarfase.Pontos - 10;
        pagar.temProduto = false;
        pagar.produtoAtual = null;
        TelaInicio.bombom = false;
    }

}
