using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public static class BuildSetting
{
    [UnityEditor.MenuItem("MyMenu/MyBuild", false, 1)]
    public static void MyBuild()
    {
        string cPath = "C:/Users/User/Desktop";
        string path = cPath + "/Build";

        // �ش� path�� ����
        FileInfo pathInfo = new FileInfo(path);
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
        BuildPipeline.BuildPlayer(scene, path + "/build.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
    }

}
