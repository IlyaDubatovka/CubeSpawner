using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoloringManager : MonoBehaviour
{
    private Color _startColor;

    private Renderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _startColor = Random.ColorHSV(0.15f,0.5f,0.8f,1,0.8f,1);
        _renderer.material.color = _startColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
