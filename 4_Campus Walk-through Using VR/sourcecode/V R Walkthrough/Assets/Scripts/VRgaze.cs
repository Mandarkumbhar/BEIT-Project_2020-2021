using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VRgaze : MonoBehaviour
{
    public Image imgGaze;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfRay = 10;
    private RaycastHit _hit;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceOfRay))
        {
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Teleport"))
            {
                _hit.transform.gameObject.GetComponent<Teleport>().TeleportPlayer();
            }
            //if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Tv"))
            //{
            // _hit.transform.gameObject.GetComponent<Video>().StartVideo();
            //}
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Entry"))
            {
                _hit.transform.gameObject.GetComponent<Entryexit>().EnterPlayer();
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Exit"))
            {
                _hit.transform.gameObject.GetComponent<Entryexit>().ExitPlayer();
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("EntryR"))
            {
                _hit.transform.gameObject.GetComponent<EntryexitR>().EnterPlayer();
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("ExitR"))
            {
                _hit.transform.gameObject.GetComponent<EntryexitR>().ExitPlayer();
            }
        }

    }
    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }
}
