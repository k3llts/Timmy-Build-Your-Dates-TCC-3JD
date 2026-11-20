using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoOssoPelaCamera : MonoBehaviour
{
    private ConfigurableJoint junta;

    public float forca = 1000;
    public float amortecimento = 10;

    void Start()
    {
        junta = GetComponent<ConfigurableJoint>();

        JointDrive drive = junta.slerpDrive;
        
            drive.positionSpring = forca; 
            drive.positionDamper = amortecimento;
            junta.slerpDrive = drive;
        

        junta.rotationDriveMode = RotationDriveMode.Slerp;
    }

    void FixedUpdate()
    {
        girarEmY();
    }

    void girarEmY() 
    {
        //direção da frente da camera
        Vector3 frenteDaCamera = Camera.main.transform.forward;

        //deixa o y diboinha
        frenteDaCamera.y = 0;
        frenteDaCamera.Normalize();


        //prepara a rotação pra ser usada
        Quaternion rotacaoCameraAlvo = Quaternion.LookRotation(frenteDaCamera);

        //aplica a rotação na joint
        junta.targetRotation = Quaternion.Inverse(rotacaoCameraAlvo);
    }
}
