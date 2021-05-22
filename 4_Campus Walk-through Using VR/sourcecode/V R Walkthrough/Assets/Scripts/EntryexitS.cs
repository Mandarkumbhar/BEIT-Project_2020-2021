using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryexitS : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    public void EnterPlayer()
    {
        player.transform.position = new Vector3(transform.position.x + 16.5f, transform.position.y - 2.5f, transform.position.z);
    }

    public void ExitPlayer()
    {
        player.transform.position = new Vector3(transform.position.x - 16.5f, transform.position.y - 2.5f, transform.position.z);
    }
}
