using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoOssoPelaCamera : MonoBehaviour
{
    private ConfigurableJoint joint;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();

        JointDrive drive = joint.slerpDrive;
        
            drive.positionSpring = 1000f; //força
            drive.positionDamper = 100f; //suavidão
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
