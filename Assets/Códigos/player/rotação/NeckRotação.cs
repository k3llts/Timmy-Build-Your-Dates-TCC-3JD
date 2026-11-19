using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoPescocoCamera : MonoBehaviour
{
    private ConfigurableJoint joint;
    private Transform osso;

    public float forca = 5000;
    public float suaveza = 50;
    public float limiteAnguloY = 70f;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();

        //pega o osso em que esse ta conectado
        osso = joint.connectedBody != null ? joint.connectedBody.transform : transform.parent;

        //seta os valores de força suavidade
        JointDrive drive = joint.slerpDrive;
        drive.positionSpring = forca;
        drive.positionDamper = suaveza;
        joint.slerpDrive = drive;
        joint.rotationDriveMode = RotationDriveMode.Slerp;
    }

    void FixedUpdate()
    {
        //pega a direção da camera ignorando cima ou baixo
        Vector3 frenteCamera = Camera.main.transform.forward;
        frenteCamera.y = 0;
        frenteCamera.Normalize();

        //transforma essa direção da câmera em uma rotação que a Unity entende
        Quaternion rotacaoMundoAlvo = Quaternion.LookRotation(frenteCamera);

        //faz o calculo pro pescoço girar
        Quaternion rotationalLocalAlvo = Quaternion.Inverse(osso.rotation) * rotacaoMundoAlvo;


        //pega o ângulo de giro para os lados em graus normais
        float anguloY = rotationalLocalAlvo.eulerAngles.y;

        //faz com que olhar para esquerda seja um numero negativo
        if (anguloY > 180) anguloY -= 360;

        //não deixa ele passar do limite
        anguloY = Mathf.Clamp(anguloY, -limiteAnguloY, limiteAnguloY);

        //aplica os calculos legais com o limite no pescoço
        rotationalLocalAlvo = Quaternion.Euler(0, anguloY, 0);


        // Aplica o giro final na junta do pescoço (invertido porque esse componente da Unity funciona ao contrário)
        joint.targetRotation = Quaternion.Inverse(rotationalLocalAlvo);
    }
}
