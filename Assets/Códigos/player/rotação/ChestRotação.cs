using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoChestPelaCamera : MonoBehaviour
{
    private ConfigurableJoint joint;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();

        // Garante que o Slerp Drive está ativo com força física
        JointDrive drive = joint.slerpDrive;
        if (drive.positionSpring == 0)
        {
            drive.positionSpring = 10000f; // Força para alinhar com a câmera
            drive.positionDamper = 100f;  // Evita tremedeira
            drive.maximumForce = float.MaxValue;
            joint.slerpDrive = drive;
        }
        joint.rotationDriveMode = RotationDriveMode.Slerp;
    }

    void FixedUpdate()
    {
        // 1. Pega a rotação completa da câmera
        Quaternion rotacaoCameraCompleta = Camera.main.transform.rotation;

        // 2. Extrai os ângulos Euler para isolar as rotações
        Vector3 eulerCamera = rotacaoCameraCompleta.eulerAngles;

        // 3. Cria uma nova rotação aplicando X e Z da câmera, e zerando o Y (para não girar para os lados)
        Quaternion rotacaoAlvoXZ = Quaternion.Euler(eulerCamera.x, 0f, 0f);

        // 4. Aplica na joint usando a inversão necessária do espaço local dela
        joint.targetRotation = Quaternion.Inverse(rotacaoAlvoXZ);
    }
}
