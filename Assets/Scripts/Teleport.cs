using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour
{
    [SerializeField] private float minOffset = 0.3f;
    [SerializeField] private float maxOffset = 1.0f;

    void OnEnable()
    {
        EventManager.OnClicked += Teleport;
    }

    void OnDisable()
    {
        EventManager.OnClicked -= Teleport;
    }

    void Teleport()
    {
        float offsetX = Random.Range(minOffset, maxOffset) * (Random.value > 0.5f ? 1 : -1);
        float offsetY = Random.Range(minOffset, maxOffset) * (Random.value > 0.5f ? 1 : -1);
        transform.position += new Vector3(offsetX, offsetY, 0f);
    }
}