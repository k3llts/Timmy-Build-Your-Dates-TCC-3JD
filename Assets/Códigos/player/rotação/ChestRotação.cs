using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoChestPelaCamera : MonoBehaviour
{
    private ConfigurableJoint junta;
    public float forca = 500;
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
        girarEmX();
    }

    void girarEmX() 
    {
        //pega a rotation of camera
        Quaternion rotacaoCameraCompleta = Camera.main.transform.rotation;

        //pega os angulo em euler
        Vector3 eulerCamera = rotacaoCameraCompleta.eulerAngles;

        //pega o x e o z mas deixa o y quieto
        Quaternion rotacaoAlvoXZ = Quaternion.Euler(eulerCamera.x, 0f, 0f);

        //mete a rotação no osso
        junta.targetRotation = Quaternion.Inverse(rotacaoAlvoXZ);
    }
}
