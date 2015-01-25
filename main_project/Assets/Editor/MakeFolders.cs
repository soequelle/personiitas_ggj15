using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;
 
 
public class MakeFolders : ScriptableObject
{
 
    [MenuItem ( "Assets/Make Project Folders" )]
    static void MenuMakeFolders()
    {
		CreateFolders();
	}
 
	static void CreateFolders()
	{
		string f = Application.dataPath + "/";
 
		Directory.CreateDirectory(f + "3D");
		Directory.CreateDirectory(f + "Fonts");
		Directory.CreateDirectory(f + "Plugins");
		Directory.CreateDirectory(f + "Textures");
		Directory.CreateDirectory(f + "Materials");
		Directory.CreateDirectory(f + "Scenes");
		Directory.CreateDirectory(f + "Audio");
		Directory.CreateDirectory(f + "Prefabs");
		Directory.CreateDirectory(f + "Scripts");
		Directory.CreateDirectory(f + "Sounds");
		Directory.CreateDirectory(f + "UI");
 
		Debug.Log("Created directories");
	}
}