using UnityEngine;
using System.Collections;
using System.Threading.Tasks;

public class Async : MonoBehaviour
{
    public async Task RotateForSeconds(float duration) //Task - dont have to physically return a value
    {
        var end = Time.time + duration;
        while (Time.time < end)
        {
            transform.Rotate(new Vector3(1, 1) * Time.deltaTime * 150);
            await Task.Yield();
        }
    }
}