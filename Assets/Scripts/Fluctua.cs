using UnityEngine;
using UnityEngine.UIElements;

public class Fluctua : MonoBehaviour
{
    [SerializeField]
    private int speed;
    private float positionx;
    private float positionz;
    private float positiony;
    [SerializeField]
    private int amplitud;
    void Start()
    {
        positionx = transform.position.x;
        positionz = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        positiony =transform.position.y;
        Vector3 dir = new Vector3(positionx, positionx + (amplitud * Mathf.Sin(speed * Time.time)),positionz );
        transform.position = dir;
    }
}
