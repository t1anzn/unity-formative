using UnityEngine;

public class CollisionColour : MonoBehaviour
{
    private Renderer _renderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.GetComponent<CollisionColour>() != null)
        {
            _renderer.material.color = Color.black;
        }
        else
        {
            _renderer.material.color = Color.red;
        }
}}
