using UnityEngine;

public class RotateEnemy : MonoBehaviour
{
    public GameObject gameManager;
    public float speed;
    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().GameState == GameState.Playing)
            transform.Rotate(new Vector3(0, 0, speed));
    }
    private void LateUpdate()
    {

    }
    private void FixedUpdate()
    {
    }
}
