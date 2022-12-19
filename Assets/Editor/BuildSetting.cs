using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class BuildSetting : MonoBehaviour
{
    public static void MyBuild()
    {
        string cPath = System.IO.Directory.GetCurrentDirectory();
        string path = cPath + "/Build";

        // �ش� path�� ����
        FileInfo pathInfo = new System.IO.FileInfo(path);
        // Build �� ����
        string[] scene = { "Assets/Scenes/SampleScene.unity" };
        // �� ������ path ����

        // �ش� �ּҿ� ������ �����ϴ���
        if(pathInfo.Exists == false)
        {
            // �ش� �ּҿ� ���� ���� ����
            Directory.CreateDirectory(path);
        }
        // �������� ����
        BuildPipeline.BuildPlayer(scene, path + "/build.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }

}
