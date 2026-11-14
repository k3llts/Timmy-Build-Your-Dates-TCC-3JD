using UnityEngine;

public class ControlarAnimacaoGuia : MonoBehaviour
{
    private Animator anim;
    private string estadoAtual = ""; // Guarda qual animação está tocando agora

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        bool estaAndando = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) ||
                           Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);

        if (estaAndando)
        {
            TrocarAnimacao("Andandinho"); // Coloque o nome exato da sua animação de andar
        }
        else
        {
            TrocarAnimacao("paradinho");  // Coloque o nome exato da sua animação parado
        }
    }

    // Só manda tocar a animação se ela for diferente da que já está rodando
    void TrocarAnimacao(string novaAnimacao)
    {
        if (estadoAtual == novaAnimacao) return;

        anim.Play(novaAnimacao);
        estadoAtual = novaAnimacao;
    }
}
