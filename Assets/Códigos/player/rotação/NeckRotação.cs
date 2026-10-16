using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoPescocoCamera : MonoBehaviour
{
    private ConfigurableJoint joint;
    private Transform osso;

    public float forca = 5000;
    public float suaveza = 50;

    public float limiteAnguloY = 70f; // Máximo que o pescoço pode virar para a esquerda ou direita (ex: 70 graus)

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();

        //pega o osso q o pescoço ta conectado
        osso = joint.connectedBody != null ? joint.connectedBody.transform : transform.parent;

        //as força
        JointDrive drive = joint.slerpDrive;
        drive.positionSpring = forca;
        drive.positionDamper = suaveza;
        joint.slerpDrive = drive;

        joint.rotationDriveMode = RotationDriveMode.Slerp;
    }

    void FixedUpdate()
    {
        //direção da camera
        Vector3 frenteCamera = Camera.main.transform.forward;
        frenteCamera.y = 0;
        frenteCamera.Normalize();

        //coloca o valor da rotação da camera em uma classe
        Quaternion rotacaoMundoAlvo = Quaternion.LookRotation(frenteCamera);

        //passa o valor convertido quaternion para outra classe final
        Quaternion rotationalLocalAlvo = Quaternion.Inverse(osso.rotation) * rotacaoMundoAlvo;

        // --- SISTEMA DE LIMITE (ADICIONADO) ---
        // Converte a rotação local para ângulos de Euler e extrai o eixo Y
        float anguloY = rotationalLocalAlvo.eulerAngles.y;

        // Corrige o ângulo da Unity para trabalhar com valores negativos (-180 a 180)
        if (anguloY > 180) anguloY -= 360;

        // Limita o ângulo com base na variável que você configurou no Inspector
        anguloY = Mathf.Clamp(anguloY, -limiteAnguloY, limiteAnguloY);

        // Recria a rotação local com o ângulo devidamente travado
        rotationalLocalAlvo = Quaternion.Euler(0, anguloY, 0);
        // --------------------------------------

        //aplica o giro
        joint.targetRotation = Quaternion.Inverse(rotationalLocalAlvo);
    }
}
