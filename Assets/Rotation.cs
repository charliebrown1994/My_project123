using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] GameObject cube;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RotationCube();
        }
    }

    void RotationCube()
    {
        cube.transform.Rotate(0, 45, 0);
    }
}
