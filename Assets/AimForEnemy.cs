using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimForEnemy : MonoBehaviour
{
    public Transform targetObject; // Przypisz obiekt, którego pozycjê chcesz œledziæ
    float x;
    float y;
   


    void Update()
    {
        if (targetObject != null)
        {
            // Pobierz pozycjê obiektu docelowego
            Vector3 targetPosition = targetObject.position;

            // Przemieszczaj ten obiekt do pozycji obiektu docelowego
            transform.position = targetPosition;
        }
    }
}
