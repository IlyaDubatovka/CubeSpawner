using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    [SerializeField] private float _coloringDuration;
    private float _curentTime;
    private GameObject _cube;
    private Color _curentColor;
    private Color _startColor;

    private Color _finalColor;
    // Start is called before the first frame update
    void Start()
    {
        _curentColor = Random.ColorHSV(0, 1, 0.5f, 0.8f, 0.5f, 0.8f, 1,1);
        _startColor = _curentColor;
        _finalColor = Random.ColorHSV(0,1,0.5f,0.8f,0.5f,0.8f,1,1);
    }

    // Update is called once per frame
    void Update()
    {
        _curentTime += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            _cube=Instantiate(_prefab);

            _cube.transform.position = new Vector3(Random.Range(-2,2), Random.Range(18,22), Random.Range(-2,2));
        }

        _cube.GetComponent<Renderer>().material.color = _curentColor;
        _curentColor = Color.Lerp(_startColor, _finalColor, _coloringDuration);
    }
}
