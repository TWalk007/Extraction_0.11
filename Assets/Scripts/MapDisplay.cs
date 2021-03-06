﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{

    public Renderer textureRender;
    public MeshFilter meshFilter;
    public MeshRenderer meshRenderer;

    public void DrawTexture (Texture2D texture)
    {
        // Instead of using texture.material (instantiated at runtime only).  We want to preview in the Editor.
        // So we'll use "sharedMaterial"
        textureRender.sharedMaterial.mainTexture = texture;
        //Now we'll make sure the the texture is the same size as our map.
        textureRender.transform.localScale = new Vector3(texture.width, 1, texture.height);
    }

    public void DrawMesh(MeshData meshData, Texture2D texture)
    {
        meshFilter.sharedMesh = meshData.CreateMesh();
        meshRenderer.sharedMaterial.mainTexture = texture;
    }

}
