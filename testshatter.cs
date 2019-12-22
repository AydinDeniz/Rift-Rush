using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testshatter : MonoBehaviour {
    public bool extra_detonate = false;
    public GameObject[] extra_detonated;
    
    public int particle_count;
    public float scale_var;
    public float force;
    public float radius;
    public Vector3 offset;

    public void Detonate()
    {
        
        
        
            Debug.Log("detonated");
            if (extra_detonate == true)
            {
                foreach(GameObject obje in extra_detonated)
                {
                obje.GetComponent<testshatter>().Detonate();
                }
               
            }
            StartCoroutine(SplitMesh(true));
            
       
    }

    public IEnumerator SplitMesh(bool destroy)
    {
        if (GetComponent<MeshFilter>() == null || GetComponent<SkinnedMeshRenderer>() == null)
        {
            yield return null;
        }


        if (GetComponent<Collider>())
        {
            GetComponent<Collider>().enabled = false;
        }

        Mesh M = new Mesh();
        if (GetComponent<MeshFilter>())
        {
            M = GetComponent<MeshFilter>().mesh;
        }
        else if (GetComponent<SkinnedMeshRenderer>())
        {
            M = GetComponent<SkinnedMeshRenderer>().sharedMesh;
        }

        Material[] materials = new Material[0];
        if (GetComponent<MeshRenderer>())
        {
            materials = GetComponent<MeshRenderer>().materials;
        }
        else if (GetComponent<SkinnedMeshRenderer>())
        {
            materials = GetComponent<SkinnedMeshRenderer>().materials;
        }

        Vector3[] verts = M.vertices;
        Vector3[] normals = M.normals;
        Vector2[] uvs = M.uv;
        for (int submesh = 0; submesh < M.subMeshCount; submesh++)
        {

            int[] indices = M.GetTriangles(submesh);

            for (int i = 0; i < indices.Length; i += 3)
            {
                Vector3[] newVerts = new Vector3[3];
                Vector3[] newNormals = new Vector3[3];
                Vector2[] newUvs = new Vector2[3];
                for (int n = 0; n < 3; n++)
                {
                    int index = indices[i + n];
                    newVerts[n] = verts[index];
                    newUvs[n] = uvs[index];
                    newNormals[n] = normals[index];
                }

                Mesh mesh = new Mesh();
                mesh.vertices = newVerts;
                mesh.normals = newNormals;
                mesh.uv = newUvs;

                mesh.triangles = new int[] { 0, 1, 2, 2, 1, 0 };

                GameObject GO = new GameObject("Triangle " + (i /3));
                GO.layer = LayerMask.NameToLayer("Particle");
                GO.transform.position = transform.position+offset;
                GO.transform.rotation = transform.rotation;
                GO.transform.localScale = GO.transform.localScale * scale_var;
                GO.AddComponent<MeshRenderer>().material = materials[submesh];
                GO.AddComponent<MeshFilter>().mesh = mesh;
                GO.AddComponent<BoxCollider>();
                Vector3 explosionPos = new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(0f, 0.5f), transform.position.z + Random.Range(-0.5f, 0.5f));
                GO.AddComponent<Rigidbody>().AddExplosionForce(Random.Range(0+force, 0+force), explosionPos, radius);
                GO.GetComponent<Rigidbody>().useGravity = false;
                GO.GetComponent<Rigidbody>().drag = 0.5f;
                Destroy(GO, 5 + Random.Range(0.0f, 5.0f));
            }
        }

        GetComponent<Renderer>().enabled = false;

        
        

    }
    public void Destroy()
    {
        
        Destroy(gameObject);
        
    }


}

