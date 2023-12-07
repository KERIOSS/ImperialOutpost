using UnityEngine;
using EzySlice;
public class Slicer : MonoBehaviour
{
    public Material materialAfterSlice;
    public LayerMask sliceMask;
    public bool isTouched;
    AudioSource cut;
    private void Start()
    {
        cut = GetComponent<AudioSource>();

    }
    private void Update()
    {
        if (isTouched == true)
        {
            isTouched = false;
            Collider[] objectsToBeSliced = Physics.OverlapBox(transform.position, new Vector3(1, 0.1f, 0.1f), transform.rotation, sliceMask);
            foreach (Collider objectToBeSliced in objectsToBeSliced)
            {
                SlicedHull slicedObject = SliceObject(objectToBeSliced.gameObject, materialAfterSlice);
                GameObject upperHullGameobject = slicedObject.CreateUpperHull(objectToBeSliced.gameObject, materialAfterSlice);
                GameObject lowerHullGameobject = slicedObject.CreateLowerHull(objectToBeSliced.gameObject, materialAfterSlice);
                upperHullGameobject.transform.position = objectToBeSliced.transform.position;
                lowerHullGameobject.transform.position = objectToBeSliced.transform.position;
                MakeItPhysical(upperHullGameobject);
                MakeItPhysical(lowerHullGameobject);
                Destroy(upperHullGameobject, 5f);
                Destroy(lowerHullGameobject, 5f);

                Destroy(objectToBeSliced.gameObject);
            }
        }
        
    }
    private void MakeItPhysical(GameObject obj)
    {
        Rigidbody rb = obj.AddComponent<Rigidbody>();
        MeshCollider collider = obj.AddComponent<MeshCollider>();
        collider.convex = true;
        rb.AddExplosionForce(100, obj.transform.position, 1);
        ScoreManager.scorecount += 1;
        cut.Play();

    }

    private SlicedHull SliceObject(GameObject obj, Material crossSectionMaterial = null)
    {
        return obj.Slice(transform.position, transform.up, crossSectionMaterial);

    }


}
