using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(ConfigurableJoint))]
public class SincronizarJoint : MonoBehaviour
{
    public Transform alvo;

    public float forca = 1500f;// foça pra copiar
    public float amortecimento = 50f;// suaveza do movimento 

  
    private ConfigurableJoint joint;
    private Rigidbody rb;

    // rotações iniciais salvas no inicio do jogo
    private Quaternion rotacaoInicialAlvo;
    private Quaternion rotacaoInicialObjeto;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
        rb = GetComponent<Rigidbody>();

        ConfigurarFisica();
        ConfigurarMotorDaJoint();
        SalvarRotacoesIniciais();
    }

    void FixedUpdate()
    {
        if (alvo == null) return;// só funciona se o alvo não for vazio

        
        AplicarRotacaoDoAlvo(); //pega a rotação do alvo e aplica na joint
    }



    private void ConfigurarFisica()
    {
        //configura o rigidbody pra poder usar
        rb.useGravity = false;
        rb.angularDamping = 0.5f;
    }

    private void ConfigurarMotorDaJoint()
    {
        // Configuração do slerp no configurable joint

        joint.rotationDriveMode = RotationDriveMode.Slerp;// muda o tipo da força pra slerp
        JointDrive motor = new JointDrive();//criando novo motor para usar
        motor.positionSpring = forca;// escolhe a quantidade de força
        motor.positionDamper = amortecimento;// escolhe a quantidade de amortecimento da força
        motor.maximumForce = Mathf.Infinity; // Destrava o limite de força do motor

        joint.slerpDrive = motor;//manda as configurações do motor pra joint
    }

    private void SalvarRotacoesIniciais()
    {
        //bem autoexplicativo, essa parte salva as rotações iniciais
        if (alvo != null)
        {
            rotacaoInicialAlvo = alvo.rotation;
        }
        rotacaoInicialObjeto = transform.rotation;
        /*para fazer com que o movimento ignore as posições e se baseie apenas na posição inicial de cada um
        ou seja se um mover 30 graus pra direita o outro vai seguir,
        ignorando se eles já estavam ou não apontando para a mesma direção*/
    }



    private void AplicarRotacaoDoAlvo()
    {
        //descobre o quanto o alvo girou desde o inicio do jogo
        Quaternion diferencaDeGiro = alvo.rotation * Quaternion.Inverse(rotacaoInicialAlvo);

        // soma esse giro a rotação do nosso objeto
        Quaternion rotacaoDesejada = diferencaDeGiro * rotacaoInicialObjeto;

        // envia a rotação convertida para a Configurable Joint poder girar
        joint.targetRotation = ConverterParaEspacoDaJoint(rotacaoDesejada);
    }

    /*a configurable joint usa um sistema de eixos invertido
    essa função traduz a rotação normal da Unity para o formato que a joint entende*/
    private Quaternion ConverterParaEspacoDaJoint(Quaternion rotacaoNoMundo)
    {
        Vector3 direita = joint.axis;
        Vector3 frente = Vector3.Cross(joint.axis, joint.secondaryAxis).normalized;
        Vector3 cima = Vector3.Cross(frente, direita).normalized;

        Quaternion espacoDaJoint = Quaternion.LookRotation(frente, cima);

        Quaternion resultado = Quaternion.Inverse(espacoDaJoint);
        resultado *= Quaternion.Inverse(rotacaoNoMundo) * rotacaoInicialObjeto;
        resultado *= espacoDaJoint;

        return resultado;
    }
}
