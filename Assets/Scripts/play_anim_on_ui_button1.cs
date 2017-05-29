using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class play_anim_on_ui_button1 : MonoBehaviour
{

    public Button Text;
    public AudioClip sound;
    public Animator ani;
    public Animator ani2;
    public Animator ani3;

    public Canvas yourcanvas;



    void Start()
    {
        Text = Text.GetComponent<Button>();
        ani.enabled = false;
        ani2.enabled = false;
        ani3.enabled = false;
        yourcanvas.enabled = true;
    }


    public void Press()

    {
        Text.enabled = true;
        AudioSource.PlayClipAtPoint(sound, transform.position);
        ani.enabled = true;
        ani2.enabled = true;
        ani3.enabled = true;
        //Destroy(Text, 1);
        //yourcanvas.enabled = false;

    }
}
