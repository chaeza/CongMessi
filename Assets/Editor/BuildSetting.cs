using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class BuildSetting : MonoBehaviour
{
    [UnityEditor.MenuItem("MyMenu/MyBuild", false, 1)]
    public static void MyBuild()
    {
        string cPath = System.IO.Directory.GetCurrentDirectory();
        string path = cPath + "/Build/";

        // �ش� path�� ����
        System.IO.FileInfo pathInfo = new System.IO.FileInfo("C:/ProgramData/Jenkins.jenkins/workspace/congMessi_Build/Build");
        // Build �� ����
        string[] scene = { "Assets/Scenes/SampleScene.unity" };
        // �� ������ path ����
        System.IO.FileInfo[] Scenes = new System.IO.FileInfo[scene.Length];

        // �ش� �ּҿ� ������ �����ϴ���
        if(pathInfo.Exists == false)
        {
            // �ش� �ּҿ� ���� ���� ����
            System.IO.Directory.CreateDirectory("C:/ProgramData/Jenkins.jenkins/workspace/congMessi_Build/Build");
        }

        // �������� ����
        UnityEditor.BuildPipeline.BuildPlayer(scene, "C:/ProgramData/Jenkins.jenkins/workspace/congMessi_Build/Build/build.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
