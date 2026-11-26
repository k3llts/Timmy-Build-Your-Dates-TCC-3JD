using UnityEngine;

//[RequireComponent(typeof(ConfigurableJoint))]
public class LevantarBracoDir : MonoBehaviour
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
        //botão direito do mouse (1)
        if (Input.GetMouseButtonDown(1))
        {
            BracoForte();
        }
        else if (Input.GetMouseButtonUp(1))
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
