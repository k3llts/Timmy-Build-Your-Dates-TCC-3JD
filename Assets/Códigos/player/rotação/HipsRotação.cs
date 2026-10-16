using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoOssoPelaCamera : MonoBehaviour
{
    private ConfigurableJoint joint;

    public float forfa = 500;
    public float suavidade = 10;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();

        JointDrive drive = joint.slerpDrive;
        
            drive.positionSpring = forfa; 
            drive.positionDamper = suavidade;
            joint.slerpDrive = drive;
        

        joint.rotationDriveMode = RotationDriveMode.Slerp;
    }

    void FixedUpdate()
    {
        //direção da frente da camera
        Vector3 frenteDaCamera = Camera.main.transform.forward;

        //deixa o y diboinha
        frenteDaCamera.y = 0;
        frenteDaCamera.Normalize();

        
            //prepara a rotação pra ser usada
            Quaternion rotacaoCameraAlvo = Quaternion.LookRotation(frenteDaCamera);

            //aplica a rotação na joint
            joint.targetRotation = Quaternion.Inverse(rotacaoCameraAlvo);
        
    }
}
