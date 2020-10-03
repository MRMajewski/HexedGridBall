using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{

    public GameObject firstCanvas;
    public GameObject yesCanvas;

    public AudioSource firstAudio;
    public AudioSource yesAudio;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Quit();
        }
    }

    public void ChangeCanvas()
    {
        firstCanvas.SetActive(false);
        yesCanvas.SetActive(true);
        firstAudio.gameObject.SetActive(false);
        yesAudio.Play();


    }

    

    private void Quit()
    {
        Application.Quit();
    }
}
