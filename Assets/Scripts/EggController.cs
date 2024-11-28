using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject eggPrefab;
    private UIManager uimanager;

    private void Start()
    {
        uimanager = Object.FindFirstObjectByType<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (uimanager != null)
            {
                uimanager.EatEgg();
            }
            Destroy(gameObject);
        }
        else if (collision.CompareTag("BoxDestroyEgg"))
        {
            if (uimanager != null)
            {
                uimanager.MissEgg();
            }
            Destroy(gameObject);

            GameObject eggCrack = Instantiate(eggPrefab, transform.position, Quaternion.identity);
            Destroy(eggCrack, 1f);
        }
    }
}
