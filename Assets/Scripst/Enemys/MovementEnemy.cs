using UnityEngine;

public class MovementEnemy : MonoBehaviour
{

    public float speed;
    public Transform pointA;
    public Transform pointB;
    private float posYScreen;
    private float widthObj;
    private int dir;
    private Vector3 posA;
    private Vector3 posB;
    private bool flagA = false;
    private Renderer renderer;
    // Use this for initialization
    void Start()
    {
        dir = 1;
        renderer = GetComponent<Renderer>();
        posA = pointA.position;
        posA.x += renderer.bounds.size.x / 2;

        posB = pointB.position;
        posB.x -= renderer.bounds.size.x / 2;
        posYScreen = -Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0)).y;
        widthObj = GetComponent<Renderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        AIMove_1();
        AutoDestroy();
    }
    void Move()
    {
        // C1:
        //transform.Translate(Vector3.down * speed * Time.deltaTime);

        // C2:
        //Vector3 temp = transform.position;
        //temp.y -= speed * Time.deltaTime;
        //transform.position = temp;

        // C3:
        //transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.down, speed * Time.deltaTime);

        // C4:
        transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.down, speed * Time.deltaTime);

        // C5:
    }
    void AutoDestroy()
    {
        if (transform.position.y < posYScreen - widthObj / 2)
            Destroy(gameObject);
    }
    void AIMove_1()
    {
        if (flagA == false)
        {
            posA.y = transform.position.y;
            transform.position = Vector3.MoveTowards(transform.position, posA, speed * Time.deltaTime);
            if (transform.position.x == posA.x)
                flagA = true;
        }
        else // flagA = true
        {
            posB.y = transform.position.y;
            transform.position = Vector3.MoveTowards(transform.position, posB, speed * Time.deltaTime);
            if (transform.position.x == posB.x)
                flagA = false;
        }
    }
    
}
