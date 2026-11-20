using UnityEngine;

//[RequireComponent(typeof(ConfigurableJoint))]
public class LevantarBracoEsq : MonoBehaviour
{
    private ConfigurableJoint braco;


    public float bracoForteMola = 10000f;
    public float bracoForteAmortecer = 100f;


    public float bracoFracoMola = 25f;
    public float bracofracoAmortecer = 5f;



    void Start()
    {
        braco = GetComponent<ConfigurableJoint>();
        braco.rotationDriveMode = RotationDriveMode.Slerp;

        //começa sem força
        BracoFraco();
    }

    void Update()
    {
        //botão esquerdo do mouse (0)
        if (Input.GetMouseButtonDown(0))
        {
            BracoForte();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            BracoFraco();
        }
    }


     void BracoForte()
    {
        JointDrive drive = braco.slerpDrive;

        drive.positionSpring = bracoForteMola;
        drive.positionDamper = bracoForteAmortecer;

        braco.slerpDrive = drive;
    }


     void BracoFraco()
    {
        JointDrive drive = braco.slerpDrive;

        drive.positionSpring = bracoFracoMola;
        drive.positionDamper = bracofracoAmortecer;

        braco.slerpDrive = drive;
    }
}
