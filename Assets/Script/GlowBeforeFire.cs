using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowBeforeFire : MonoBehaviour
{
    public float szybkoscZmiany = 1.0f;
    private MeshRenderer meshRenderer;
    private Material material;
    private float czasOstatniejZmiany;
    private Color pierwotnaWartoscEmission;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            material = meshRenderer.material;
            czasOstatniejZmiany = Time.time;
            pierwotnaWartoscEmission = material.GetColor("_EmissionColor");
        }
        else
        {
            Debug.LogError("Nie znaleziono komponentu MeshRenderer z materia�em!");
            enabled = false;
        }
    }

    void Update()
    {
        if (Time.time - czasOstatniejZmiany >= 1.0f)
        {
            ZmienEmission();
            czasOstatniejZmiany = Time.time;
        }
    }

    void ZmienEmission()
    {
        if (material != null && material.HasProperty("_EmissionColor"))
        {
            float pingPongValue = Mathf.PingPong(Time.time * szybkoscZmiany, 1f);
            Color aktualnyEmission = pierwotnaWartoscEmission * pingPongValue;
            
            // Ustawiamy now� warto�� Emission
            material.SetColor("_EmissionColor", aktualnyEmission);
        }
        else
        {
            Debug.LogError("Materia� nie obs�uguje Emission lub nie ma w�a�ciwo�ci '_EmissionColor'!");
        }
    }

    void LateUpdate()
    {
        if (Time.time - czasOstatniejZmiany >= 5.0f)
        {
            // Przywracamy pierwotn� warto�� Emission
            material.SetColor("_EmissionColor", pierwotnaWartoscEmission);
        }
    }
}
