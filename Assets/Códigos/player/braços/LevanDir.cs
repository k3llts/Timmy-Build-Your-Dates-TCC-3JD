using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class LevantarBracoDir : MonoBehaviour
{
    private ConfigurableJoint joint;


    public float forcaMaximaSpring = 10000f;
    public float forcaMaximaDamper = 100f;


    public float forcaMinimaSpring = 25f;
    public float forcaMinimaDamper = 5f;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
        joint.rotationDriveMode = RotationDriveMode.Slerp;

        // Inicia com as forças baixas
        Fraco();
    }

    void Update()
    {
        // 0 detecta o botão esquerdo do mouse
        if (Input.GetMouseButtonDown(1))
        {
            Forte();
        }
        else if (Input.GetMouseButtonUp(1))
        {
            Fraco();
        }
    }

    // Função chamada ao clicar com o mouse
    public void Forte()
    {
        JointDrive drive = joint.slerpDrive;

        drive.positionSpring = forcaMaximaSpring;
        drive.positionDamper = forcaMaximaDamper;

        joint.slerpDrive = drive;
    }

    // Função chamada ao soltar o mouse
    public void Fraco()
    {
        JointDrive drive = joint.slerpDrive;

        drive.positionSpring = forcaMinimaSpring;
        drive.positionDamper = forcaMinimaDamper;

        joint.slerpDrive = drive;
    }
}
