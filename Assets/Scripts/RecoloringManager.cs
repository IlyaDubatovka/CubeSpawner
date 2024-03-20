using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoloringManager : MonoBehaviour
{
    private float _currentTime;
    private Color _startColor;
    private Color _finalColor;

    private Renderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _startColor = GenerateNewColor();
        _renderer.material.color = _startColor;
        _finalColor = GenerateNewColor();
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;
        _renderer.material.color = Color.Lerp(_startColor, _finalColor, _currentTime);
    }

    private Color GenerateNewColor()
    {
        return Random.ColorHSV(0, 1, 1, 1, 0.5f, 0.9f);
    }
}
