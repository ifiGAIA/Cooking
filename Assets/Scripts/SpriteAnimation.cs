using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteAnimation : MonoBehaviour
{
    public float Speed = 1f;
    public int FrameRate = 30;
    public bool Loop = false;
    private Image image = null;

    private Sprite[] sprites = null;
    private float TimePreFrame = 0f;
    private float ElapsedTime = 0f;
    private int CurrentFrame = 0;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        enabled = false;
        LoadSpriteSheet();
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime += Time.deltaTime * Speed;
        if(ElapsedTime >= TimePreFrame)
        {
            ElapsedTime = 0f;
            ++CurrentFrame;
            SetSprite();
            if(CurrentFrame >= sprites.Length)
            {
                if(Loop)
                {
                    CurrentFrame = 0;
                }
                else
                {
                    enabled = false;
                }
            }
        }
    }
    private void LoadSpriteSheet()
    {
        sprites = Resources.LoadAll<Sprite>("Initialain");
        if(sprites != null && sprites.Length > 0)
        {
            TimePreFrame = 1f / FrameRate;
            Play();
        }
        else
        {
            Debug.Log("5555..");
        }
    }
    public void Play()
    {
        enabled = true;
    }
    private void SetSprite()
    {
        if(CurrentFrame >= 0 && CurrentFrame < sprites.Length)
        {
            image.sprite = sprites[CurrentFrame];
        }
    }
}
