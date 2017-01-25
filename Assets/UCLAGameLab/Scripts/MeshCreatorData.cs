/****************************************************************************
Copyright (c) 2013, Jonathan Cecil and UCLA Game Lab
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice, this
list of conditions and the following disclaimer.
2. Redistributions in binary form must reproduce the above copyright notice,
this list of conditions and the following disclaimer in the documentation
and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*****************************************************************************/

using UnityEngine;
using System.Collections;
using UnityEditor;

public class MeshCreatorData : MonoBehaviour {
	public string errorMessage = "reinstall the mesh creator package.";
	
	// use this texture for creating the outine
	public Texture2D outlineTexture;
    public float pixelTransparencyThreshold = 255;
	public const float versionNumber = 0.7f;
	
	// settings for what the script will create
	public bool uvWrapMesh = true;
	public bool createEdges = true;
	public bool createBacksidePlane = false;
	
	// stores an automatically created material
	public Material frontMaterial;
	
	// total height, width, and depth of the resulting mesh
	public float meshHeight = 1.0f; 
	public float meshWidth = 1.0f; 
	public float meshDepth = 0.1f;
	
	// set center pivot offset
	public float pivotHeightOffset = 0.0f;
	public float pivotWidthOffset = 0.0f;
	public float pivotDepthOffset = 0.0f;
	
	// store the last pivot offset used so it can be subtracted from next
	public Vector3 lastPivotOffset = Vector3.zero;
	
	// collider settings
	public bool generateCollider = true;
	public bool usePrimitiveCollider = true;
    public bool useAABBCollider = false;
    public int maxNumberBoxes = 20;
    public bool useAutoGeneratedMaterial = false;
	public bool usePhysicMaterial = false;
	public PhysicMaterial physicMaterial;
    public bool setTriggers = false;
	
	public string idNumber = "";
	
	public bool mergeClosePoints = false;
	public float mergeDistance = 0.0f;

	
}
