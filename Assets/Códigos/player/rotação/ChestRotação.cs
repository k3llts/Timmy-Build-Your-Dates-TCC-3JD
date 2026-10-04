using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoChestPelaCamera : MonoBehaviour
{
    private ConfigurableJoint joint;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();


        JointDrive drive = joint.slerpDrive;
        
            drive.positionSpring = 10000f; //forfa
            drive.positionDamper = 100f;  //suavizations
            joint.slerpDrive = drive;
        
        joint.rotationDriveMode = RotationDriveMode.Slerp;
    }

    void FixedUpdate()
    {
        //pega de rotation of da camera
        Quaternion rotacaoCameraCompleta = Camera.main.transform.rotation;

        //pega os angulo em euler
        Vector3 eulerCamera = rotacaoCameraCompleta.eulerAngles;

        //pega o x e o z mas deixa o y queto
        Quaternion rotacaoAlvoXZ = Quaternion.Euler(eulerCamera.x, 0f, 0f);

        //mete a rotação no coiso
        joint.targetRotation = Quaternion.Inverse(rotacaoAlvoXZ);
    }
}
