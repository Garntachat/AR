using UnityEngine;

public class Self_Destruct : MonoBehaviour
{
    public GameObject effectz;
    void Start()
    {
        Invoke("DoSomethingAfterDelay", 2f);
    }

    void DoSomethingAfterDelay()
    {

        Instantiate(effectz, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
