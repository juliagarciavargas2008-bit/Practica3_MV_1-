using UnityEngine;
using UnityEngine.UIElements;

public class Fluctua : MonoBehaviour
{
    [SerializeField]
    private float frecuencia; 
    [SerializeField]
    private float amplitud;

    private float positionx;
    private float positionz;
    private float positiony;
   
    void Start()
    {
        positionx = transform.position.x;
        positionz = transform.position.z;
        positiony = transform.position.y + Random.Range(-0.1f,0.1f) ;
    }

    void Update()
    {
        Vector3 dir = new Vector3(positionx, positiony + (amplitud * Mathf.Sin(frecuencia * Time.time)), positionz);
        transform.position = dir;
    }
}
