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

        // 해당 path의 정보
        FileInfo pathInfo = new FileInfo(path);
        // Build 할 씬들
        string[] scene = { "Assets/Scenes/SampleScene.unity" };
        // 그 씬들의 path 정보

        // 해당 주소에 파일이 존재하는지
        if(pathInfo.Exists == false)
        {
            // 해당 주소에 새로 폴더 생성
            Directory.CreateDirectory(path);
        }
        // 실질적인 빌드
        BuildPipeline.BuildPlayer(scene, path + "/build.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
    }

}
