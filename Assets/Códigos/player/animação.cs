using UnityEngine;

// Garante que este objeto tenha uma ConfigurableJoint antes de rodar o código
[RequireComponent(typeof(ConfigurableJoint))]
public class CopiaMusculo : MonoBehaviour
{
    [Header("Configuração")]
    [Tooltip("Arraste para cá o osso que tem a animação")]
    [SerializeField] private Transform ossoAnimado;

    private ConfigurableJoint junta;
    private Quaternion rotacaoInicial;

    void Start()
    {
        // Pega o componente de física deste objeto
        junta = GetComponent<ConfigurableJoint>();

        // Guarda a posição em que o osso começou o jogo
        rotacaoInicial = transform.localRotation;
    }

    void FixedUpdate()
    {
        // Se você esqueceu de arrastar o osso animado, o código para por aqui para não dar erro
        if (ossoAnimado == null || junta == null) return;

        // 1. Pega apenas o giro no eixo Y (para os lados) do osso animado
        float giroY = ossoAnimado.localEulerAngles.y;

        // 2. Cria uma rotação nova usando SOMENTE esse giro no eixo Y (deixando X e Z zerados)
        Quaternion rotacaoApenasY = Quaternion.Euler(0f, giroY, 0f);

        // 3. Aplica o giro na física (a junta da Unity funciona de trás para frente, por isso usamos o Inverse)
        junta.targetRotation = Quaternion.Inverse(rotacaoApenasY) * rotacaoInicial;
    }
}
