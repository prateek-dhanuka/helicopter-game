using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed;
    private RawImage _image;

    // Start is called before the first frame update
    void Start()
    {
        if (! _image) _image = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = _image.uvRect.position + new Vector2(scrollSpeed, 0f);
        if (position.x > 1) position.x -= 1f;
        _image.uvRect = new Rect(position, _image.uvRect.size);
    }
}
