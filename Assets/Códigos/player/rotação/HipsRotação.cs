using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class RotacaoOssoPelaCamera : MonoBehaviour
{
    private ConfigurableJoint joint;

    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();

        // Garante que o Slerp Drive está ativo com força física
        JointDrive drive = joint.slerpDrive;
        if (drive.positionSpring == 0)
        {
            drive.positionSpring = 1000f; // Força para alinhar com a câmera (pode aumentar se achar lento)
            drive.positionDamper = 100f;   // Evita tremedeira
            drive.maximumForce = float.MaxValue;
            joint.slerpDrive = drive;
        }

        joint.rotationDriveMode = RotationDriveMode.Slerp;
    }

    void FixedUpdate()
    {
        // 1. Pega a direção para onde a câmera está olhando no mundo
        Vector3 frenteDaCamera = Camera.main.transform.forward;

        // 2. Zera o eixo Y para o personagem não inclinar para cima/baixo se você olhar pro céu/chão
        frenteDaCamera.y = 0;
        frenteDaCamera.Normalize();

        if (frenteDaCamera != Vector3.zero)
        {
            // 3. Cria a rotação baseada puramente no olhar da câmera
            Quaternion rotacaoCameraAlvo = Quaternion.LookRotation(frenteDaCamera);

            // 4. Aplica na joint usando a inversão necessária do espaço local dela
            joint.targetRotation = Quaternion.Inverse(rotacaoCameraAlvo);
        }
    }
}
