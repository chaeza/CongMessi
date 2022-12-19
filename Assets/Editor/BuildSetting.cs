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
        string path = cPath + "Build";

        // 해당 path의 정보
        System.IO.FileInfo pathInfo = new System.IO.FileInfo(path);
        // Build 할 씬들
        string[] scene = { "Assets/Scenes/SampleScene.unity" };
        // 그 씬들의 path 정보
        System.IO.FileInfo[] Scenes = new System.IO.FileInfo[scene.Length];

        // 해당 주소에 파일이 존재하는지
        if(pathInfo.Exists == false)
        {
            // 해당 주소에 새로 폴더 생성
            System.IO.Directory.CreateDirectory(path);
        }

        // 씬들 주소 정보 담아서 체크
        for(int i= 0; i < Scenes.Length; i++)
        {
            Scenes[i] = new System.IO.FileInfo(cPath+ "/" + scene[i]);

            // 해당 파일이 없으면 
            if(Scenes[i].Exists == false)
            {
                // 빌드 안함
                return;
            }
        }

        // 실질적인 빌드
        UnityEditor.BuildPipeline.BuildPlayer(scene, path + "build.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
