using UnityEngine;

public class RotateAroundTarget : MonoBehaviour
{
    // used when rotate object around target, but always start at top, that is error
    // Use this for initialization
    [SerializeField]
    private float RotateSpeed;
    private float Radius;
    [SerializeField]
    private Transform target;
    private float _angle;
    void Start()
    {
        CalculateRadius();
    }

    // Update is called once per frame
    void Update()
    {
        
       // AIRotateAround_1();
        transform.Rotate(new Vector3(0, 0, -1));
    }
    void CalculateRadius()
    {
        float x = target.position.x - transform.position.x;
        float y = target.position.y - transform.position.y;
        float z = target.position.z - transform.position.z;
        Radius = -Mathf.Sqrt(x * x + y * y);
    }
    void AIRotateAround_1()
    {
        _angle += RotateSpeed * Time.deltaTime;

        Vector3 offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
        transform.position = target.position + offset;
    }
}
