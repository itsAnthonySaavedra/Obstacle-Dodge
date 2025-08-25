using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float projectileSpeed = 3f;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        projectileLaunch();
        DestroyOnReach();
    }

    void projectileLaunch()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, projectileSpeed * Time.deltaTime);
    }
    void DestroyOnReach()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
