using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoPescocoCamera : MonoBehaviour
{
    private ConfigurableJoint joint;
    private Transform ossoPai;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();

        // Descobre automaticamente o osso do peito/corpo onde o pescoço está conectado
        ossoPai = joint.connectedBody != null ? joint.connectedBody.transform : transform.parent;

        // Configura as forças físicas do pescoço para serem firmes e suaves
        JointDrive drive = joint.slerpDrive;
        drive.positionSpring = 2000f; // Força para olhar para a câmera
        drive.positionDamper = 500f;   // Amortecimento para eliminar tremores
        drive.maximumForce = float.MaxValue;
        joint.slerpDrive = drive;

        joint.rotationDriveMode = RotationDriveMode.Slerp;
    }

    void FixedUpdate()
    {
        // 1. Pega a direção da câmera no horizonte
        Vector3 frenteDaCamera = Camera.main.transform.forward;
        frenteDaCamera.y = 0;
        frenteDaCamera.Normalize();

        if (frenteDaCamera != Vector3.zero && ossoPai != null)
        {
            // 2. Rotação desejada no mundo global
            Quaternion rotacaoMundoAlvo = Quaternion.LookRotation(frenteDaCamera);

            // 3. Converte a rotação da câmera para o espaço local do osso pai (peito)
            // Isso impede que o pescoço trema ou trave quando o corpo gira
            Quaternion rotationalLocalAlvo = Quaternion.Inverse(ossoPai.rotation) * rotacaoMundoAlvo;

            // 4. Aplica na Configurable Joint com a inversão física necessária
            joint.targetRotation = Quaternion.Inverse(rotationalLocalAlvo);
        }
    }
}
