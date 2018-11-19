using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject gameManager;
    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }
    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().GameState == GameState.Playing)
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
            PlayerDead();
        }
    }
    void PlayerDead()
    {
        Debug.Log("Game Over");
        // gameObject.SetActive(false);
        gameManager.GetComponent<GameManager>().GameState = GameState.Over;
    }
}
