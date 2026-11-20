using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoPescocoCamera : MonoBehaviour
{
    private ConfigurableJoint junta;
    private Transform objetoConectado;

    public float forca = 5000;
    public float amortecimento = 50;
    public float limiteEmY = 70f;

    void Start()
    {
        junta = GetComponent<ConfigurableJoint>();

        //pega o osso em que esse ta conectado
        objetoConectado = junta.connectedBody != null ? junta.connectedBody.transform : transform.parent;

        //seta os valores de força suavidade
        JointDrive drive = junta.slerpDrive;
        drive.positionSpring = forca;
        drive.positionDamper = amortecimento;
        junta.slerpDrive = drive;
        junta.rotationDriveMode = RotationDriveMode.Slerp;
    }

    void FixedUpdate()
    {
        girarComLimite();
    }

    void girarComLimite() 
    {
        //pega a direção da camera ignorando cima ou baixo
        Vector3 frenteCamera = Camera.main.transform.forward;
        frenteCamera.y = 0;
        frenteCamera.Normalize();

        //transforma essa direção da câmera em uma rotação que a Unity entende
        Quaternion rotacaoMundoAlvo = Quaternion.LookRotation(frenteCamera);

        //faz o calculo pro pescoço girar
        Quaternion rotationalLocalAlvo = Quaternion.Inverse(objetoConectado.rotation) * rotacaoMundoAlvo;


        //pega o ângulo de giro para os lados em graus normais
        float anguloY = rotationalLocalAlvo.eulerAngles.y;

        //faz com que olhar para esquerda seja um numero negativo
        if (anguloY > 180) anguloY -= 360;

        //não deixa ele passar do limite
        anguloY = Mathf.Clamp(anguloY, -limiteEmY, limiteEmY);

        //aplica os calculos legais com o limite no pescoço
        rotationalLocalAlvo = Quaternion.Euler(0, anguloY, 0);


        // Aplica o giro final na junta do pescoço (invertido porque esse componente da Unity funciona ao contrário)
        junta.targetRotation = Quaternion.Inverse(rotationalLocalAlvo);
    }
}
