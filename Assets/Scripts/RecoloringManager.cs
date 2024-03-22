
using UnityEngine;

public class RecoloringManager : MonoBehaviour
{
    [HideInInspector] public float recoloringDuration;
    [HideInInspector] public float delayDuration;

    private float _cycleTimer;
    private Color _startColor;
    private Color _finalColor;

    private Renderer _renderer;

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
        _cycleTimer += Time.deltaTime;
        _renderer.material.color = Color.Lerp(_startColor, _finalColor, _cycleTimer/recoloringDuration);
        if (_cycleTimer>=recoloringDuration+delayDuration)
        {
            _startColor = _finalColor;
            _finalColor = GenerateNewColor();
            _cycleTimer = 0;
        }
    }

    private Color GenerateNewColor()
    {
        return Random.ColorHSV(0, 1, 1, 1, 0.5f, 0.9f);
    }
}