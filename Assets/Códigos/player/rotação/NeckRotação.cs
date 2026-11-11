using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoPescocoCamera : MonoBehaviour
{
    private ConfigurableJoint joint;
    private Transform osso;

    public float forca = 5000;
    public float suaveza = 50;
    // O máximo que o pescoço pode virar para os lados (ex: 70 graus para a esquerda ou direita)
    public float limiteAnguloY = 70f;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();

        // Descobre qual é o osso do corpo onde o pescoço está preso (geralmente o peito/coluna)
        osso = joint.connectedBody != null ? joint.connectedBody.transform : transform.parent;

        // Configura a força e o "freio" do pescoço para ele não girar rápido demais nem ficar mole
        JointDrive drive = joint.slerpDrive;
        drive.positionSpring = forca;
        drive.positionDamper = suaveza;
        joint.slerpDrive = drive;
        joint.rotationDriveMode = RotationDriveMode.Slerp;
    }

    void FixedUpdate()
    {
        // Descobre para onde a câmera está olhando, ignorando se ela olha para cima ou para baixo
        Vector3 frenteCamera = Camera.main.transform.forward;
        frenteCamera.y = 0;
        frenteCamera.Normalize();

        // Transforma essa direção da câmera em uma rotação que a Unity entende
        Quaternion rotacaoMundoAlvo = Quaternion.LookRotation(frenteCamera);

        // Calcula o quanto o pescoço precisa girar em relação ao corpo
        Quaternion rotationalLocalAlvo = Quaternion.Inverse(osso.rotation) * rotacaoMundoAlvo;


        // Pega o ângulo de giro para os lados (eixo Y) em graus normais
        float anguloY = rotationalLocalAlvo.eulerAngles.y;

        /* Ajusta a conta para que virar para a esquerda seja um número negativo (ex: -70) 
         e virar para a direita seja positivo (ex: 70)*/
        if (anguloY > 180) anguloY -= 360;

        // Impede que o pescoço passe do limite máximo que você escolheu (evita girar 360 graus)
        anguloY = Mathf.Clamp(anguloY, -limiteAnguloY, limiteAnguloY);

        // Monta a rotação final já com esse limite aplicado
        rotationalLocalAlvo = Quaternion.Euler(0, anguloY, 0);


        // Aplica o giro final na junta do pescoço (invertido porque esse componente da Unity funciona ao contrário)
        joint.targetRotation = Quaternion.Inverse(rotationalLocalAlvo);
    }
}
