using UnityEngine;
using System.Collections;

public class linecast : MonoBehaviour
{
    public GameObject Player_Martijn;
    public Transform target;
    void Update()
    {
        var player = GameObject.Find("Player_Martijn");
        if (Physics.Linecast(transform.position, target.position))
        {
            var script = Player_Martijn.GetComponent<Health>();
            script.Kill();
            Debug.Log("blocked");
        }
    }
}
