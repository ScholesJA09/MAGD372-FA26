using UnityEngine;
using System.Collections;

public class Coroutine : MonoBehaviour
{
    public IEnumerator RotateForSeconds(float duration)
    {
        var end = Time.time + duration;
        while (Time.time < end)
        {
            transform.Rotate(new Vector3(1, 1) * Time.deltaTime * 150);
            yield return null;
        }
    }
}