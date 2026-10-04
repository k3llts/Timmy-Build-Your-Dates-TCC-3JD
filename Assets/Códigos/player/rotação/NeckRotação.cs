using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoPescocoCamera : MonoBehaviour
{
    private ConfigurableJoint joint;
    private Transform osso;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();

        //pega o osso q o pescoço ta conectado
        osso = joint.connectedBody != null ? joint.connectedBody.transform : transform.parent;

        //as força
        JointDrive drive = joint.slerpDrive;
        drive.positionSpring = 2000f;//força
        drive.positionDamper = 500f;//suaveza
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

        //aplica o giro
        joint.targetRotation = Quaternion.Inverse(rotationalLocalAlvo);
    
    }
}
