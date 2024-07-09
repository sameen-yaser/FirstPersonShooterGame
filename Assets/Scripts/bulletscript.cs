using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    public AudioSource dieaudio;

    // Start is called before the first frame update
    void Start()
    {
        dieaudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.2f);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.StartsWith("enemy"))
        {
            if (dieaudio != null && dieaudio.enabled)
            {
                dieaudio.Play();
            }
        }
    }
}
