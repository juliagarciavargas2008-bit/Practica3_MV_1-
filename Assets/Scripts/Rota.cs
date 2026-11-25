using Unity.Mathematics;
using UnityEngine;

public class Rota : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private float rotationy;
    void Start()
    {
        rotationy = transform.rotation.y;
    }

    void Update()
    {
        transform.Rotate(0, rotationy + speed, 0);
    }
}
