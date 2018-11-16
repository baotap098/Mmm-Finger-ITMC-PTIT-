using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // Debug.Log("Input.mousePosition: " + Input.mousePosition);
            Vector3 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log("When Convert to WorldPoint: " + posMouse);
            posMouse.z = 0;
            transform.position = Vector3.MoveTowards(transform.position, posMouse, 1);
        }
    }
    private void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Enemy")
        {
            Debug.Log("Game Over");
        }
    }
}
